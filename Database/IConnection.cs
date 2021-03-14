using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;

namespace project1.Database
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
            // Utils.IncrementalNameParametrs().Zip(parametrs) does not work, why https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.zip?view=net-5.0#System_Linq_Enumerable_Zip__2_System_Collections_Generic_IEnumerable___0__System_Collections_Generic_IEnumerable___1__
            => connection.Execute(sql, Utils.IncrementalNameParametrs().Zip(parametrs, Tuple.Create));

        public static void Execute<T>(this IConnection<T> connection, string sql)
            => connection.Execute(sql, Array.Empty<(string, object)>());


        public static object RequestValue<T>(this IConnection<T> connection, string sql, IEnumerable<object> parametrs)
            => connection.RequestValue(sql, Utils.IncrementalNameParametrs().Zip(parametrs, Tuple.Create));

        public static object RequestValue<T>(this IConnection<T> connection, string sql)
            => connection.RequestValue(sql, Enumerable.Empty<(string, object)>());


        public static DataSet Request<T>(this IConnection<T> connection, string sql, IEnumerable<(string, object)> parametrs)
            => connection.Request(sql, new DataSet(), parametrs);

        public static DataSet Request<T>(this IConnection<T> connection, string sql, IEnumerable<object> parametrs)
            // Tuple.Create does not work, why
            => connection.Request(sql, new DataSet(), Utils.IncrementalNameParametrs().Zip(parametrs, (a, b) => (a, b)));

        public static DataSet Request<T>(this IConnection<T> connection, string sql)
            => connection.Request(sql, new DataSet(), Enumerable.Empty<(string, object)>());
    }
}
