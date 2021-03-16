using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;

namespace ViauslDB.Database
{
    public interface IConnection<T> : IDisposable
    {
        void Execute(string sql, IEnumerable<(string, object)> parametrs);

        object RequestValue(string sql, IEnumerable<(string, object)> parametrs);

        DataSet Request(string sql, DataSet dataSet, IEnumerable<(string, object)> parametrs);
    }

    public static class IConnectionExtension
    {
        public static void Execute<T>(this IConnection<T> connection, string sql, IEnumerable<object> parametrs)
            => connection.Execute(sql, Utils.IncrementalNameParametrs().Zip(parametrs, (a, b) => (a, b)));

        public static void Execute<T>(this IConnection<T> connection, string sql)
            => connection.Execute(sql, Array.Empty<(string, object)>());


        public static object RequestValue<T>(this IConnection<T> connection, string sql, IEnumerable<object> parametrs)
            => connection.RequestValue(sql, Utils.IncrementalNameParametrs().Zip(parametrs, (a, b) => (a, b)));

        public static object RequestValue<T>(this IConnection<T> connection, string sql)
            => connection.RequestValue(sql, Enumerable.Empty<(string, object)>());


        public static DataSet Request<T>(this IConnection<T> connection, string sql, IEnumerable<(string, object)> parametrs)
            => connection.Request(sql, new DataSet(), parametrs);

        public static DataSet Request<T>(this IConnection<T> connection, string sql, IEnumerable<object> parametrs)
            => connection.Request(sql, new DataSet(), Utils.IncrementalNameParametrs().Zip(parametrs, (a, b) => (a, b)));

        public static DataSet Request<T>(this IConnection<T> connection, string sql)
            => connection.Request(sql, new DataSet(), Enumerable.Empty<(string, object)>());
    }
}
