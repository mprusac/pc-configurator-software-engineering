using System.Data;
using System.Data.SqlClient;

namespace Konfigo
{
    public static class DB
    {
        private static SqlConnection _connection;

        private static string _connectionString = @"Data Source=31.147.206.65;
            Initial Catalog=PI2425_mprusac23_DB;
            User ID=PI2425_mprusac23_User;
            Password=EQ}Q@sxJ";

        public static void OpenConnection()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        public static void CloseConnection()
        {
            if (_connection != null && _connection.State != ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

        public static SqlDataReader GetDataReader(string query)
        {
            SqlCommand command = new SqlCommand(query, _connection);
            return command.ExecuteReader();
        }

        public static int ExecuteCommand(string query)
        {
            SqlCommand command = new SqlCommand(query, _connection);
            return command.ExecuteNonQuery();
        }

        public static SqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
