using System;
using System.Windows.Forms;

namespace ViauslDB.Forms
{
    public partial class CreateViewForm : Form
    {
        public string ViewName => viewName.Text;

        public CreateViewForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
