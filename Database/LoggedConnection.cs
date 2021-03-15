using System;
using System.Data;
using System.Collections.Generic;
using ViauslDB.Log;
using System.Text.RegularExpressions;

namespace ViauslDB.Database
{
    public class LoggedConnection<T> : IConnection<T>
    {
        public IConnection<T> InnerConnection { get; set; }
        public ILogger Logger { get; set; }

        public LoggedConnection(IConnection<T> innerConnection, ILogger logger)
        {
            InnerConnection = innerConnection;
            Logger = logger;
        }

        void IConnection<T>.Execute(string sql, IEnumerable<(string, object)> parametrs)
        {
            Log(sql);
            InnerConnection.Execute(sql, parametrs);
        }

        DataSet IConnection<T>.Request(string sql, DataSet dataSet, IEnumerable<(string, object)> parametrs)
        {
            Log(sql);
            return InnerConnection.Request(sql, dataSet, parametrs);
        }

        object IConnection<T>.RequestValue(string sql, IEnumerable<(string, object)> parametrs)
        {
            Log(sql);
            return InnerConnection.RequestValue(sql, parametrs);
        }

        void IDisposable.Dispose()
        {
            InnerConnection.Dispose();
        }

        private void Log(string query)
        {
            var formated = Regex.Replace(query, @"\t|\n|\r| +", " ");
            Logger.Info(formated);
        }
    }
}
