using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MiniSupermarket.Models
{
    internal static class Connection
    {
        private static string serverName = "MSI\\SQLEXPRESS";
        private static string databaseName = "MarketMiniManager";

        private static string connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(connectionString);
        public static SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
