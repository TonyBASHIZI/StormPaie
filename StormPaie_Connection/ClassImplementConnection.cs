using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace StormPaie_Connection
{
    public class ImplementConnection : IConnection
    {
        private IDbConnection _conn = null;
        private static ImplementConnection _instance = null;

        public IDbConnection Conn
        {
            get
            {
                return _conn;
            }

            set
            {
                _conn = value;
            }
        }

        public static ImplementConnection Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ImplementConnection();
                return _instance;
            }
        }

        public IDbConnection Initialise(Connection connection, ConnectionType connectionType)
        {
            switch (connectionType)
            {
                case ConnectionType.SQLServer:
                    _conn = new SqlConnection(string.Format("Data source={0}; Initial catalog={1}; User ID={2}; Password={3}",
                        connection.Server, connection.Database, connection.User, connection.Password));
                    break;

                case ConnectionType.MySQL:
                    _conn = new MySqlConnection(string.Format("Server={0}; Database={1}; UserID={2}; Password={3}",
                    connection.Server, connection.Database, connection.User, connection.Password));
                    return null;

                case ConnectionType.Access:
                    return null;
            }
            return _conn;
        }
    }
}
