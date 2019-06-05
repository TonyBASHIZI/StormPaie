using System;
using System.IO;

namespace StormPaie_Connection
{
    public class Connection
    {
        public string path;

        public void Connect()
        {
            //pubCon.testFile();
            path = File.ReadAllText(Constants.Database.Path).Trim();
        }
    }
}
