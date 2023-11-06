using System.Data.SqlClient;

namespace backEnd.Helpers
{
    public static class DBConnectionHelper
    {
        private static SqlConnection connection;

        static DBConnectionHelper()
        {
            GetConnection();
        }

        public static SqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(getConnectionString());
                connection.Open();
            }
            return connection;
        }

        public static string getConnectionString()
        {
            using IHost host = Host.CreateDefaultBuilder().Build();

            var config = host.Services.GetService<IConfiguration>();

            string cnxStr = config.GetConnectionString("DefaultConnection") ?? "";
            return cnxStr;
        }

        public static async Task<SqlCommand> getConnectedSqlCommand(string query)
        {
            SqlCommand result;
            SqlConnection sql = connection;
            result = new SqlCommand(query, sql);
            return result;
        }
    }
}


