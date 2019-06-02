using StormPaie_Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StormPaie_Lib.Classes
{
    public class Glossaire
    {
        private static Glossaire _instance = null;

        public static Glossaire Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Glossaire();
                return _instance;
            }
        }

        public void InitializeConnexion()
        {
            try
            {
                if (ImplementConnection.Instance.Conn.State == ConnectionState.Closed)
                    ImplementConnection.Instance.Conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IDbDataParameter GetParameter(IDbCommand command, string parameter, DbType type, int size, object value)
        {
            IDbDataParameter param = command.CreateParameter();
            param.ParameterName = parameter;
            param.DbType = type;
            param.Size = size;
            param.Value = value;

            return param;
        }
    }
}
