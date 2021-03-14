using System;
using System.Linq;
using System.Windows.Forms;
using project1.Database;

namespace project1.Modifiers
{
    public partial class JoinTableModifier : UserControl, SelectModifier
    {
        public PgDatabase Database
        {
            get => database;
            set
            {
                database = value;

                if (database != null)
                    UpdateTableSelect();
            }
        }

        public bool Complite => !string.IsNullOrEmpty(Table)
                && !string.IsNullOrEmpty(FirstTableColumn)
                && !string.IsNullOrEmpty(SecondTableColumn);

        public event EventHandler StateChanged = delegate { };

        public string Table => tableSelect.Text;
        public string FirstTableColumn => firstTableColumnSelect.Text;
        public string SecondTableColumn => secondTableColumnSelect.Text;

        public JoinTableModifier(PgDatabase database = null)
        {
            InitializeComponent();

            Database = database;
        }

        public JoinTableModifier()
            : this(null) { }

        public void UpdateFirstColumnSelect(params string[] columns)
        {
            firstTableColumnSelect.Items.Clear();
            firstTableColumnSelect.Items.AddRange(columns);
        }

        private void UpdateSecondColumnSelect()
        {
            var columns = Database.ColumnNames(tableSelect.Text).ToArray();

            secondTableColumnSelect.Items.Clear();
            secondTableColumnSelect.Items.AddRange(columns);
        }

        private void UpdateTableSelect()
        {
            var tables = Database.TableNames().ToArray();

            tableSelect.Items.Clear();
            tableSelect.Items.AddRange(tables);
        }

        private void InnerStateChanged(object sender, EventArgs e)
        {
            StateChanged(sender, e);
        }

        private void tableSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSecondColumnSelect();
            InnerStateChanged(sender, e);
        }

        PgDatabase database;
    }
}
