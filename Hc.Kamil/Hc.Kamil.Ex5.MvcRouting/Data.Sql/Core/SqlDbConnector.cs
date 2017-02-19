using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Hc.Kamil.Ex5.MvcRouting.Data.Sql.Core
{
    public class SqlDbConnector : IDisposable
    {
        public const string ConnectionStringName = "localhost-hc.kamil";

        private readonly SqlConnection _connection;

        public SqlDbConnector()
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings[ConnectionStringName].ConnectionString);
        }

        public void Dispose()
        {
            _connection.Close();
        }

        public SqlDataReader ExecuteQueryCommand(SqlCommand command)
        {
            _connection.Open();
            command.Connection = _connection;
            return command.ExecuteReader();
        }
    }
}