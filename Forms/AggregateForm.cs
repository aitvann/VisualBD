using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ViauslDB.Database;
using Npgsql;

namespace ViauslDB.Forms
{
    public partial class AggregateForm : Form
    {
        private readonly string tableName;

        private readonly Dictionary<string, string> funs = new Dictionary<string, string>
        {
            { "Average", "avg" },
            { "Minimun", "min" },
            { "Maximun", "max" },
            { "Sum", "sum" },
        };

        public AggregateForm(PgDatabase database, string tableName)
        {
            InitializeComponent();

            this.database = database;
            this.tableName = tableName;
        }

        private void UpdateFunSelect()
        {
            var items = funs.Keys.ToArray();
            funSelect.Items.Clear();
            funSelect.Items.AddRange(items);
        }

        private void UpdateColumnSelect()
        {
            var columnNames = ColumnNames(tableName).ToArray();
            columnSelect.Items.Clear();
            columnSelect.Items.AddRange(columnNames);
        }

        private void UpdateResult()
        {
            if (string.IsNullOrEmpty(funSelect.Text) || string.IsNullOrEmpty(columnSelect.Text))
                return;

            var sql = $@"
                SELECT {funs[funSelect.Text]}({columnSelect.Text})
                FROM {tableName}";

            try
            {
                result.Text = database.Connection.RequestValue(sql).ToString();
            } catch (PostgresException)
            {
                MessageBox.Show("Invalid column type", "Error");
            }
        }

        private IEnumerable<string> ColumnNames(string tableName)
        {
            var sql = $@"
                SELECT column_name
                FROM information_schema.columns
                WHERE table_schema = 'public'
                AND table_name = '{tableName}';";

            var table = database.Connection.Request(sql).Tables[0];
            return Enumerable.Range(0, table.Rows.Count)
                .Select(i => table.Rows[i].ItemArray[0] as string);
        }

        private void AggregateForm_Load(object sender, EventArgs e)
        {
            UpdateFunSelect();
            funSelect.SelectedIndex = 0;

            UpdateColumnSelect();
        }

        private void columnSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private void funSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }

        private PgDatabase database;
    }
}
