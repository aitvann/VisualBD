using System;
using System.Text;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using Npgsql;

namespace project1.Database
{
    public class PgDatabase
    {
        public IConnection<NpgsqlConnection> Connection { get; set; }

        public PgDatabase(IConnection<NpgsqlConnection> connection)
        {
            Connection = connection;
        }

        public DataTable RequestTable(string tableName)
            => Connection.Request($"SELECT * FROM {tableName}").Tables[0];

        public DataTable RequestTable(string tableName, string[] columnNames)
            => Connection.Request($"SELECT {string.Join(",", columnNames)} FROM {tableName}").Tables[0];

        public IEnumerable<string> TableNames()
        {
            var sql = $@"
                SELECT tablename
                FROM pg_catalog.pg_tables
                WHERE schemaname != 'pg_catalog'
                AND schemaname != 'information_schema';";

            var table = Connection.Request(sql).Tables[0];
            return Enumerable.Range(0, table.Rows.Count)
                .Select(i => table.Rows[i].ItemArray[0] as string);
        }

        public IEnumerable<string> ViewNames()
        {
            var sql = $@"
                SELECT viewname
                FROM pg_catalog.pg_views
                WHERE schemaname != 'pg_catalog'
                AND schemaname != 'information_schema';";

            var table = Connection.Request(sql).Tables[0];
            return Enumerable.Range(0, table.Rows.Count)
                .Select(i => table.Rows[i].ItemArray[0] as string);
        }

        public IEnumerable<string> PrimaryKeys(string tableName)
        {
            var sql = $@"
                SELECT a.attname
                FROM pg_index i
                JOIN pg_attribute a
                    ON a.attrelid = i.indrelid
                        AND a.attnum = ANY(i.indkey)
                WHERE i.indrelid = '{tableName}'::regclass
                AND i.indisprimary;";

            var table = Connection.Request(sql).Tables[0];
            return Enumerable.Range(0, table.Rows.Count)
                .Select(i => table.Rows[i].ItemArray[0] as string);
        }

        public IEnumerable<string> DatabaseNames()
        {
            var sql = @"
                SELECT datname
                FROM pg_database
                WHERE datistemplate = false";

            var table = Connection.Request(sql).Tables[0];
            return Enumerable.Range(0, table.Rows.Count)
                .Select(i => table.Rows[i].ItemArray[0] as string);
        }

        public IEnumerable<string> ColumnNames(string tableName)
        {
            var sql = $@"
                SELECT column_name
                FROM information_schema.columns
                WHERE table_schema = 'public'
                AND table_name = '{tableName}';";

            var table = Connection.Request(sql).Tables[0];
            return Enumerable.Range(0, table.Rows.Count)
                .Select(i => table.Rows[i].ItemArray[0] as string);
        }

        public UInt64 CountRows(string tableName)
        {
            var sql = $@"
                SELECT COUNT(*)
                FROM {tableName};";

            return (UInt64)(Connection.RequestValue(sql) as Int64?);
        }

        public void CreateTable(string name, IEnumerable<string> columns)
        {
            var sql = $"CREATE TABLE {name} ({string.Join(",", columns)});";
            Connection.Execute(sql);
        }

        public void Insert(string tableName, IEnumerable<string> fields)
        {
            var sql = $"INSERT INTO {tableName} VALUES ({string.Join(",", fields)})";
            Connection.Execute(sql);
        }

        public void CreateView(string name, string selectString)
        {
            var sql = $"CREATE VIEW {name} AS {selectString};";
            Connection.Execute(sql);
        }

        public void UpdateTable(string name, string column, string value, IEnumerable<string> conditions)
        {
            var sql = $@"
                UPDATE {name}
                SET {column} = @p1
                WHERE {string.Join(" AND ", conditions)}";

            Connection.Execute(sql, value.ToEnumerable());
        }
    }
}
