namespace ViauslDB.Log
{
    public delegate void LogAddedHandler(string log);

    public interface ILogger
    {
        event LogAddedHandler LogAdded;

        void Error(string msg);
        void Warn(string msg);
        void Info(string msg);
        void Trace(string msg);
        void Debug(string msg);
    }
}
