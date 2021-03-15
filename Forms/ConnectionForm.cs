using System;
using System.Windows.Forms;

namespace ViauslDB.Forms
{
    public partial class ConnectionForm : Form
    {
        public string Host => hostInput.Text;

        public string Username => usernameInput.Text;

        public string Password => passwordInput.Text;

        public string Database => databaseSelect.SelectedItem as string;

        public ConnectionForm(params string[] databasNames)
        {
            InitializeComponent();

            passwordInput.PasswordChar = '*';

            hostInput.Text = "localhost";
            usernameInput.Text = "postgres";
            databaseSelect.Items.AddRange(databasNames);
            databaseSelect.SelectedIndex = 0;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Host) || string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Database))
            {
                MessageBox.Show("Some fields are empty", "Error");
                return;
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
