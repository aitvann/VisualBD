using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ViauslDB.Database;

namespace ViauslDB.Modifiers
{
    public partial class ColumnsSelectModifier : UserControl, SelectModifier
    {
        public PgDatabase Database { get; set; }

        public bool Complite => true;
        public event EventHandler StateChanged = delegate { };

        public IEnumerable<string> Columns
            => Enumerable.Range(0, panel.Controls.Count)
                .Select(i => panel.Controls[i].Text);

        public IEnumerable<string> SelectedColumns
            => Enumerable.Range(0, panel.Controls.Count)
                .Select(i => panel.Controls[i] as CheckBox)
                .Where(cb => cb.Checked)
                .Select(cb => cb.Text);

        public ColumnsSelectModifier(PgDatabase database)
        {
            InitializeComponent();

            this.tableNames = new List<string>();
            Database = database;
        }

        public ColumnsSelectModifier()
            : this(null) { }

        public void AddTable(string name)
        {
            tableNames.Add(name);
            UpdatePanel();
        }

        public void AddTableRange(params string[] columnNames)
        {
            tableNames.AddRange(columnNames);
            UpdatePanel();
        }

        public void Clear()
        {
            tableNames.Clear();
            UpdatePanel();
        }

        public bool Contains(string name)
        {
            return tableNames.Contains(name);
        }

        public void RemoveTableAt(int index)
        {
            tableNames.RemoveAt(index);
            UpdatePanel();
        }

        private void UpdatePanel()
        {
            panel.Controls.Clear();

            var withName = tableNames.Count > 1;
            var checkboxes = tableNames
                .Select(t => Database.ColumnNames(t).Select(c => (withName ? $"{t}." : "") + c))
                .SelectMany(c => c)
                .Select((c, i) => CreateCheckBox(c, i))
                .ToArray();

            panel.Controls.AddRange(checkboxes);
        }

        private CheckBox CreateCheckBox(string text, int i)
        {
            var checkBox = new CheckBox();
            checkBox.Text = text;
            checkBox.Location = new Point(10, 4 + i * 20);
            checkBox.Checked = true;
            checkBox.CheckedChanged += InnerStateChanged;

            return checkBox;
        }

        private void InnerStateChanged(object sender, EventArgs e)
        {
            if (SelectedColumns.Count() != 0)
                StateChanged(sender, e);
            else
                (sender as CheckBox).Checked = true;
        }

        private List<string> tableNames;
    }
}
