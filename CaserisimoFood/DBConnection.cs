using MySql.Data.MySqlClient;

namespace CaserisimoFood
{
    internal class DBConnection
    {
        public MySqlConnection connection;
        private string host = "localhost";
        private string port = "3306";
        private string user = "root";
        private string password = "root";
        private string dbName = "caserisimo_food";
        private string connectionString;

        public DBConnection()
        {
            this.connectionString = $"Database={dbName};DataSource={host};User Id={user};Password={password}";
        }

        public MySqlConnection getConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(this.connectionString);
            }

            connection.Open();
            return connection;
        }

    }
}
