using System;
using System.IO;

namespace StormPaie_Connection
{
    public class Connection
    {
        public string path;

        public void Connect()
        {
            path = File.ReadAllText(Constants.Database.Path).Trim();
        }
    }
}
