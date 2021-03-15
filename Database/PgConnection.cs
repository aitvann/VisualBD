using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Npgsql;

namespace ViauslDB.Database
{
    public class PgConnection : IConnection<NpgsqlConnection>
    {
        public PgConnection(string connectionString)
        {
            _connection = new NpgsqlConnection(connectionString);
            _connection.Open();
        }

        void IConnection<NpgsqlConnection>.Execute(string sql, IEnumerable<(string, object)> parametrs)
        {
            var cmd = new NpgsqlCommand(sql, _connection);

            var parametrArray = parametrs.Select(t => new NpgsqlParameter(t.Item1, t.Item2)).ToArray();
            Utils.AddParametrsFromDescription(parametrs, cmd.Parameters);
            cmd.ExecuteNonQuery();
        }

        object IConnection<NpgsqlConnection>.RequestValue(string sql, IEnumerable<(string, object)> parametrs)
        {
            var cmd = new NpgsqlCommand(sql, _connection);
            Utils.AddParametrsFromDescription(parametrs, cmd.Parameters);
            return cmd.ExecuteScalar();
        }

        DataSet IConnection<NpgsqlConnection>.Request(string sql, DataSet dataSet, IEnumerable<(string, object)> parametrs)
        {
            var cmd = new NpgsqlCommand(sql, _connection);
            Utils.AddParametrsFromDescription(parametrs, cmd.Parameters);

            var dataAdapter = new NpgsqlDataAdapter(cmd);
            dataAdapter.Fill(dataSet);
            return dataSet;
        }

        void IDisposable.Dispose() => _connection.Dispose();

        private NpgsqlConnection _connection;
    }
}
