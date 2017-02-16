using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HC.Radek.Ex5.Routing.Data.Sql
{
    public class SqlConnector
    {
        private string connectionString;
        private static readonly string ConnectionStringName = @"local-Radek";
        private SqlConnection connection;

        public SqlConnector()
        {
            connectionString = ConfigurationManager.ConnectionStrings[ConnectionStringName].ConnectionString;
        }

        public void connect()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public void close()
        {
            if(connection != null)
            {
                connection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return connection;
        }


    }
}