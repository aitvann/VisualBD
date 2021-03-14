using System;
using System.Windows.Forms;

namespace project1.Modifiers
{
    public partial class OrderModifier : UserControl, SelectModifier
    {
        public bool Complite => !string.IsNullOrEmpty(Column);
        public event EventHandler StateChanged = delegate { };

        public bool Ascending => orderSelect.SelectedIndex == 0;
        public string Column => columnSelect.Text;

        public OrderModifier()
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

        private void OrderControl_Load(object sender, EventArgs e)
        {
            orderSelect.SelectedIndex = 0;
        }
    }
}
