using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViauslDB.Forms
{
    public partial class InsertForm : Form
    {
        public string TableName => tableName.Text;

        public int Length => 5;

        [System.Runtime.CompilerServices.IndexerName("FieldArray")]
        public string this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: return field1.Text;
                    case 1: return field2.Text;
                    case 2: return field3.Text;
                    case 3: return field4.Text;
                    case 4: return field5.Text;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }

        public IEnumerable<string> Fields
            => Enumerable.Range(0, Length)
                .Select(i => this[i])
                .Where(f => !string.IsNullOrEmpty(f));

        public InsertForm()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
