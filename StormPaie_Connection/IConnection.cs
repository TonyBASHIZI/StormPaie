using System.Data;

namespace StormPaie_Connection
{
    internal interface IConnection
    {
        IDbConnection Initialise(Connection connection, ConnectionType connectionType);
    }
}
