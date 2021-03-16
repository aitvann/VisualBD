using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ViauslDB.Modifiers;
using ViauslDB.Database;

namespace ViauslDB
{
    public partial class SelectView : UserControl
    {
        public TableModifier TableSelect { get; set; }
        public ColumnsSelectModifier ColumnsSelect { get; set; }
        public PageSelectorModifier PageSelect { get; set; }
        public FilterModifier Filter { get; set; }
        public OrderModifier Order { get; set; }
        public JoinTableModifier JoinTable { get; set; }

        public PgDatabase Database { get; set; }

        public uint ContentHeight
            => (uint)grid.Rows.GetRowsHeight(DataGridViewElementStates.None) + (uint)grid.ColumnHeadersHeight;

        public uint ContentWidth
            => (uint)grid.Columns.GetColumnsWidth(DataGridViewElementStates.None);

        public SelectView()
        {
            InitializeComponent();
        }

        public string SelectString
        {
            get
            {
                var columns = ColumnsSelect.SelectedColumns.ToArray();
                var sql = $@"
                SELECT {string.Join(",", columns)}
                FROM {TableSelect.Table}";

                if (JoinTable.Complite)
                    sql += $@"
                    INNER JOIN {JoinTable.Table}
                    ON {TableSelect.Table}.{JoinTable.FirstTableColumn}
                        = {JoinTable.Table}.{JoinTable.SecondTableColumn}";

                if (Filter.Complite)
                    sql += $" WHERE {Filter.Column} LIKE '{Filter.Predicate}%'";

                if (Order.Complite)
                    sql += $" ORDER BY {Order.Column} {(Order.Ascending ? "ASC" : "DESC")}";

                sql += $@"
                LIMIT {PageSelect.PageSize}
                OFFSET {(PageSelect.Page - 1) * PageSelect.PageSize}";

                return sql;
            }
        }

        public void UpdateTable()
        {
            try
            {
                grid.DataSource = Database.Connection.Request(SelectString).Tables[0];
                AdjustSize();
            } catch (Npgsql.PostgresException) { } // ignore exception
        }

        private void AdjustSize()
        {
            int scrollBar = 0;
            if (ContentWidth >= Width)
                scrollBar += 1;

            if (ContentHeight >= Height)
                scrollBar += 2;

            grid.ScrollBars = (ScrollBars)scrollBar;

            uint newWidth = Math.Min((uint)Size.Width, ContentWidth);
            uint newHeight = Math.Min((uint)Size.Height, ContentHeight);
            grid.Size = new Size((int)newWidth, (int)newHeight);
        }

        private void grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var changedColumn = grid.Columns[e.ColumnIndex].HeaderText;
            var newValue = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            var keyColumns = Database.PrimaryKeys(TableSelect.Table);
            var conditions = Enumerable.Range(0, grid.Columns.Count)
                .Select(i => grid.Columns[i])
                .Where(c => keyColumns.Contains(c.HeaderText))
                .Select(c => $"{c.HeaderText} = {grid.Rows[e.RowIndex].Cells[c.Index].Value}")
                .ToArray();

            Database.UpdateTable(TableSelect.Table, changedColumn, newValue, conditions);
        }
    }
}
