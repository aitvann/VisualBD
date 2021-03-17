using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ViauslDB.Forms;
using ViauslDB.Database;
using ViauslDB.Log;
using Npgsql;

namespace ViauslDB
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            view.TableSelect = tableSelect;
            view.ColumnsSelect = columnsSelect;
            view.PageSelect = pageSelector;
            view.Filter = filter;
            view.Order = order;
            view.JoinTable = joinTable;

            logger = new InMemoryLogger();
            SetDatabase("Host=localhost;Port=5432;Username=postgres;Password=7o-4W_;Database=postgres");

            pageSelector.PageSize = 16;
        }

        private void SetDatabase(string connectionString)
        {
            IConnection<NpgsqlConnection> connection = new PgConnection(connectionString);
            connection = new LoggedConnection<NpgsqlConnection>(connection, logger);
            database = new PgDatabase(connection);

            view.Database = database;
            columnsSelect.Database = database;
            joinTable.Database = database;
            pageSelector.Database = database;
            tableSelect.Database = database;
        }

        private bool Reconnect()
        {
            var databases = database.DatabaseNames().ToArray();
            var connForm = new ConnectionForm(databases);
            var result = connForm.ShowDialog() == DialogResult.OK;

            if (result)
                try
                {
                    var connectionString = $@"
                        Host={connForm.Host};
                        Username={connForm.Username};
                        Password={connForm.Password};
                        Database={connForm.Database}
                    ";

                    SetDatabase(connectionString);
                }
                catch (NpgsqlException exp)
                {
                    MessageBox.Show($"Invalid connection data: {exp.Message}", "Error");
                    Reconnect();
                }

            return result;
        }

        private void UpdateColumnsSelect()
        {
            columnsSelect.Clear();

            columnsSelect.AddTable(tableSelect.Table);

            if (joinTable.Complite)
                columnsSelect.AddTable(joinTable.Table);

            var columns = columnsSelect.Columns.ToArray();
            filter.UpdateColumnSelect(columns);
            order.UpdateColumnSelect(columns);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (!Reconnect())
            {
                this.Close();
                return;
            }
        }

        private void UpdateTable(object sender, EventArgs e)
        {
            view.UpdateTable();
        }

        private void tableSelect_StateChanged(object sender, EventArgs e)
        {
            var columns = database.ColumnNames(tableSelect.Table).ToArray();
            joinTable.UpdateFirstColumnSelect(columns);
            UpdateColumnsSelect();

            pageSelector.ChangeTable(tableSelect.Table);

            view.UpdateTable();
        }

        private void joinTable_StateChanged(object sender, EventArgs e)
        {
            if (tableSelect.Table == joinTable.Table)
                return;

            UpdateColumnsSelect();
            view.UpdateTable();
        }

        private void createTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createTableForm = new CreateTableForm();
            if (createTableForm.ShowDialog() != DialogResult.OK)
                return;

            database.CreateTable(createTableForm.TableName, createTableForm.Columns);
            tableSelect.UpdateSelect();
        }

        private void insertRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var insertForm = new InsertForm();
            if (insertForm.ShowDialog() != DialogResult.OK)
                return;

            database.Insert(insertForm.TableName, insertForm.Fields);
            view.UpdateTable();
        }

        private void aggregateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aggregateFrom = new AggregateForm(database, tableSelect.Text);
            aggregateFrom.Show();
        }

        private void createViwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createViewForm = new CreateViewForm();
            if (createViewForm.ShowDialog() != DialogResult.OK)
                return;

            database.CreateView(createViewForm.ViewName, view.SelectString);
            tableSelect.UpdateSelect();
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var logsForm = new LogsForm(logger);
            logsForm.Show();
        }

        private PgDatabase database;
        private InMemoryLogger logger;
    }
}
