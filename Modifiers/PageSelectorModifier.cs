using System;
using System.Drawing;
using System.Windows.Forms;
using project1.Database;

namespace project1.Modifiers
{
    public partial class PageSelectorModifier : UserControl, SelectModifier
    {
        public PgDatabase Database { get; set; }

        public UInt64 Rows
        {
            get => __rows;
            private set
            {
                __rows = value;
                AdjastPage();
            }
        }

        public UInt64 PageSize
        {
            get => __pageSize;
            set
            {
                __pageSize = value;
                AdjastPage();
            }
        }

        public UInt64 TotalPages
            => (UInt64)Math.Ceiling((double)Rows / PageSize);

        public UInt64 Page
        {
            get => __page;
            set
            {
                if (value < 1 || value > TotalPages)
                    throw new ArgumentOutOfRangeException("Page must be in the range from 1 to TotalPages");

                __page = value;

                nextButton.Enabled = Page < TotalPages;
                previousButton.Enabled = Page > 1;

                pageIndicator.Text = $"{Page} / {TotalPages}";
            }
        }

        public bool Complite => true;
        public event EventHandler StateChanged = delegate { };

        public PageSelectorModifier(PgDatabase database, UInt64 rows, UInt64 pageSize)
        {
            InitializeComponent();

            Database = database;
            __rows = rows;
            __pageSize = pageSize;
            Page = 1;
        }

        public PageSelectorModifier()
            : this(null, 1, 1) { }

        public void ChangeTable(string table)
        {
            Rows = Database.CountRows(table);
        }

        private void AdjastPage()
        {
            Page = Math.Min(Page, TotalPages);
        }

        private void UpdatePageIndicatorLocation()
        {
            var x = Width / 2 - pageIndicator.Width / 2;
            var y = Height / 2 - pageIndicator.Height / 2;
            pageIndicator.Location = new Point(x, y);
        }

        private void PageSelector_SetSize(object sender, EventArgs e)
        {
            UpdatePageIndicatorLocation();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (Page == TotalPages)
                return;

            ++Page;
            StateChanged(sender, e);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (Page == 1)
                return;

            --Page;
            StateChanged(sender, e);
        }

        private UInt64 __rows;
        private UInt64 __pageSize;
        private UInt64 __page;
    }
}
