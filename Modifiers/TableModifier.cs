using System;
using System.Linq;
using System.Windows.Forms;
using project1.Database;

namespace project1.Modifiers
{
    public partial class TableModifier : UserControl, SelectModifier
    {
        public PgDatabase Database
        {
            get => __database;
            set
            {
                __database = value;

                if (Database != null)
                    UpdateSelect();
            }
        }

        public string Table => tableSelect.Text;

        public bool Complite => !string.IsNullOrEmpty(Table);

        public event EventHandler StateChanged = delegate { };

        public TableModifier()
        {
            InitializeComponent();
        }

        public void UpdateSelect()
        {
            var tables = Database.TableNames()
                .Concat(Database.ViewNames())
                .ToArray();

            tableSelect.Items.Clear();
            tableSelect.Items.AddRange(tables);

            if (tableSelect.Items.Count > 0)
                tableSelect.SelectedIndex = 0;
        }

        private void InnerStateChanged(object sender, EventArgs e)
        {
            StateChanged(sender, e);
        }

        PgDatabase __database;
    }
}
