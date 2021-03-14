using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace project1.Forms
{
    public partial class CreateTableForm : Form
    {
        public string TableName => tableName.Text;

        public int Length => 5;

        [System.Runtime.CompilerServices.IndexerName("ColumnArray")]
        public (string, string) this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: return (name1.Text, type1.Text);
                    case 1: return (name2.Text, type2.Text);
                    case 2: return (name3.Text, type3.Text);
                    case 3: return (name4.Text, type4.Text);
                    case 4: return (name5.Text, type5.Text);
                    default: throw new IndexOutOfRangeException();
                }
            }
        }

        public IEnumerable<string> Columns
            => Enumerable.Range(0, Length)
                .Select(i => this[i])
                .Where(t => !String.IsNullOrEmpty(t.Item1) && !String.IsNullOrEmpty(t.Item2))
                .Select(t => $"{t.Item1} {t.Item2}");

        public CreateTableForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void columnTextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;

            var nospaceChars = textBox.Text.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray();
            textBox.Text = new string(nospaceChars);
        }
    }
}
