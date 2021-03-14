using System;
using System.Windows.Forms;

namespace project1.Modifiers
{
    public partial class FilterModifier : UserControl, SelectModifier
    {
        public bool Complite => !string.IsNullOrEmpty(Column)
            && !string.IsNullOrEmpty(Predicate);

        public event EventHandler StateChanged = delegate { };

        public string Predicate => predicate.Text;
        public string Column => columnSelect.Text;

        public FilterModifier()
        {
            InitializeComponent();
        }

        public void UpdateColumnSelect(params string[] columns)
        {
            columnSelect.Items.Clear();
            columnSelect.Items.AddRange(columns);
        }

        private void InnerStateChanged(object sender, EventArgs e)
        {
            StateChanged(sender, e);
        }
    }
}
