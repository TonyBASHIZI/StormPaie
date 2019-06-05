using DevExpress.XtraGrid;
using StormPaie_Connection;
using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;

namespace StormPaie_Lib.Classes
{
    public class Glossaire
    {
        private IDbCommand cmd;
        private IDataReader dr;
        private IDataAdapter adapter;

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

        #region Common

        public void InitializeConnection()
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

        public void GetDatas(GridControl grid, string field, string table)
        {
            InitializeConnection();

            try
            {
                using (cmd = ImplementConnection.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = " SELECT " + field + " FROM " + table;
                    adapter = new MySqlDataAdapter((MySqlCommand)cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    grid.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

            }
        }

        public void GetCombosData(ComboBoxEdit combo, string field, string table)
        {
            combo.Properties.Items.Clear();

            InitializeConnection();

            try
            {
                using (cmd = ImplementConnection.Instance.Conn.CreateCommand())
                {
                    cmd.CommandText = " SELECT " + field + " FROM " + table;

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        combo.Properties.Items.Add(dr[field]).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dr.Dispose();
            }
        }

        #endregion

        #region Enregistrement

        public Client GetClient(string field, string table)
        {
            Client client = null;

            InitializeConnection();

            using (cmd = ImplementConnection.Instance.Conn.CreateCommand())
            {
                string query = " SELECT nom, postnom, prenom, sexe, " +
                    "adresse, tel, matr_client, affiliation, reseaux, id_carte " +
                    "FROM " + table + " WHERE nom LIKE @field ";

                cmd.CommandText = query;

                SetParameter(cmd, "@field", DbType.String, 30, field);

                try
                {
                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        client = new Client
                        {
                            IdNFC = dr["id_carte"].ToString(),
                            Nom = dr["nom"].ToString(),
                            Postnom = dr["postnom"].ToString(),
                            Prenom = dr["prenom"].ToString(),
                            Adresse = dr["adresse"].ToString(),
                            Telephone = dr["tel"].ToString(),
                            Matricule = dr["matr_client"].ToString(),
                            Reseau = dr["reseaux"].ToString(),
                            Affiliation = dr["affiliation"].ToString(),
                            Sexe = dr["sexe"].ToString(),
                        };                      
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    dr.Close();
                }

                return client;
            }
        }

        #endregion

        #region Recharge



        #endregion

    }
}
