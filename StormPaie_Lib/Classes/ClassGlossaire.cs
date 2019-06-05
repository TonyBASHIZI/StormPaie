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
        private IDbCommand cmd;
        private IDataReader dr;

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

        private void SetParameter(IDbCommand cmd, string name, DbType type, int length, object value)
        {
            IDbDataParameter param = cmd.CreateParameter();

            param.ParameterName = name;
            param.DbType = type;
            param.Size = length;

            if (value == null)
            {
                if (!param.IsNullable)
                {
                    param.DbType = DbType.String;
                }

                param.Value = DBNull.Value;
            }
            else
            {
                param.Value = value;
            }

            cmd.Parameters.Add(param);
        }

    }
}
