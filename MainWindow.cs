using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using project1.Forms;
using project1.Database;
using project1.Log;
using Npgsql;

namespace project1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            logger = new InMemoryLogger();
            //SetDatabase("Host=localhost;Port=5432;Username=postgres;Password=7o-4W_;Database=postgres");
            //SetDatabase("Host=localhost;Port=5432;Username=aitvann;Password=m3a0F8;Database=contlist_db");
            SetDatabase("Host=localhost;Port=5432;Username=aitvann;Password=m3a0F8;Database=college1");

            pageSelector.PageSize = 16;
        }

        private void SetDatabase(string connectionString)
        {
            IConnection<NpgsqlConnection> connection = new PgConnection(connectionString);
            connection = new LoggedConnection<NpgsqlConnection>(connection, logger);
            database = new PgDatabase(connection);

            columnsSelect.Database = database;
            joinTable.Database = database;
            pageSelector.Database = database;
            table.Database = database;
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

        private void SizeDGV(DataGridView dgv)
        {
            dgv.ScrollBars = ScrollBars.None;
            var states = DataGridViewElementStates.None;
            var totalHeight = dgv.Rows.GetRowsHeight(states) + dgv.ColumnHeadersHeight;
            var totalWidth = dgv.Columns.GetColumnsWidth(states) + dgv.RowHeadersWidth;
            dgv.ClientSize = new Size(totalWidth, totalHeight);
        }

        private string SelectString
        {
            get
            {
                var columns = columnsSelect.SelectedColumns.ToArray();
                var sql = $@"
                SELECT {string.Join(",", columns)}
                FROM {table.Table}";

                if (joinTable.Complite)
                    sql += $@"
                    INNER JOIN {joinTable.Table}
                    ON {table.Table}.{joinTable.FirstTableColumn}
                        = {joinTable.Table}.{joinTable.SecondTableColumn}";

                if (filter.Complite)
                    sql += $" WHERE {filter.Column} LIKE '{filter.Predicate}%'";

                if (order.Complite)
                    sql += $" ORDER BY {order.Column} {(order.Ascending ? "ASC" : "DESC")}";

                sql += $@"
                LIMIT {pageSelector.PageSize}
                OFFSET {(pageSelector.Page - 1) * pageSelector.PageSize}";

                return sql;
            }
        }

        private void UpdateColumnsSelect()
        {
            columnsSelect.Clear();

            columnsSelect.AddTable(table.Table);

            if (joinTable.Complite)
                columnsSelect.AddTable(joinTable.Table);

            var columns = columnsSelect.Columns.ToArray();
            filter.UpdateColumnSelect(columns);
            order.UpdateColumnSelect(columns);
        }

        private void UpdateTable()
        {
            if (string.IsNullOrEmpty(table.Table))
                return;

            grid.DataSource = database.Connection.Request(SelectString).Tables[0];
            SizeDGV(grid);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //if (!Reconnect())
            //{
            //    this.Close();
            //    return;
            //}
        }

        private void UpdateTable(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void table_StateChanged(object sender, EventArgs e)
        {
            var columns = database.ColumnNames(table.Table).ToArray();
            joinTable.UpdateFirstColumnSelect(columns);
            UpdateColumnsSelect();

            pageSelector.ChangeTable(table.Table);

            UpdateTable();
        }

        private void joinTable_StateChanged(object sender, EventArgs e)
        {
            if (table.Table == joinTable.Table)
                return;

            UpdateColumnsSelect();
            UpdateTable();
        }

        private void createTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createTableForm = new CreateTableForm();
            if (createTableForm.ShowDialog() != DialogResult.OK)
                return;

            database.CreateTable(createTableForm.TableName, createTableForm.Columns);
            table.UpdateSelect();
        }

        private void insertRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var insertForm = new InsertForm();
            if (insertForm.ShowDialog() != DialogResult.OK)
                return;

            database.Insert(insertForm.TableName, insertForm.Fields);
            UpdateTable();
        }

        private void aggregateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aggregateFrom = new AggregateForm(database, table.Text);
            aggregateFrom.Show();
        }

        private void createViwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var createViewForm = new CreateViewForm();
            if (createViewForm.ShowDialog() != DialogResult.OK)
                return;

            database.CreateView(createViewForm.ViewName, SelectString);
            table.UpdateSelect();
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var logsForm = new LogsForm(logger);
            logsForm.Show();
        }

        private void grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var changedColumn = grid.Columns[e.ColumnIndex].HeaderText;
            var newValue = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            var keyColumns = database.PrimaryKeys(table.Table);
            var conditions = Enumerable.Range(0, grid.Columns.Count)
                .Select(i => grid.Columns[i])
                .Where(c => keyColumns.Contains(c.HeaderText))
                .Select(c => $"{c.HeaderText} = {grid.Rows[e.RowIndex].Cells[c.Index].Value}")
                .ToArray();

            database.UpdateTable(table.Table, changedColumn, newValue, conditions);
        }

        private PgDatabase database;
        private InMemoryLogger logger;
    }
}
