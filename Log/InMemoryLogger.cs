using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace project1.Log
{
    public class InMemoryLogger: ILogger
    {
        public Queue<string> Logs { get; private set; }

        public event LogAddedHandler LogAdded = delegate { };

        public InMemoryLogger(Queue<string> logs)
        {
            Logs = logs;
        }

        public InMemoryLogger()
            : this(new Queue<string>()) { }

        void ILogger.Error(string msg)
            => Log($"ERROR: {msg}");

        void ILogger.Warn(string msg)
            => Log($"WARNING: {msg}");

        void ILogger.Info(string msg)
            => Log($"INFO: {msg}");

        void ILogger.Trace(string msg)
            => Log($"TRACE: {msg}");

        void ILogger.Debug(string msg)
            => Log($"DEBUG: {msg}");

        private void Log(string str)
        {
            Logs.Enqueue(str);
            LogAdded(str);
        }
    }
}
