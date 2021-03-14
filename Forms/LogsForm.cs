using System.Windows.Forms;
using project1.Log;

namespace project1.Forms
{
    public partial class LogsForm : Form
    {
        public InMemoryLogger Logger
        {
            get => _logger;
            set
            {
                _logger = value;

                Logger.LogAdded += AddRecord;
                UpdateLogs();
            }
        }

        public LogsForm(InMemoryLogger logger)
        {
            InitializeComponent();

            Logger = logger;
        }

        public LogsForm()
            : this(null) { }

        public void AddRecord(string record)
        {
            logs.Text = string.Concat(logs.Text, $"{record}\n");
        }

        private void UpdateLogs()
        {
            logs.Text = string.Join("\n", Logger.Logs) + '\n';
        }

        private InMemoryLogger _logger;
    }
}
