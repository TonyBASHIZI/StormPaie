using DevExpress.XtraEditors;
using StormPaie_Lib.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StormPaie.Forms
{
    public partial class FormEnresitrement : Form
    {
        private Client client = null;

        public FormEnresitrement()
        {
            InitializeComponent();
        }

        private void FormEnresitrement_Load(object sender, EventArgs e)
        {           
            LoadGridControle();
            LoadCombos();
        }

        private void LoadCombos()
        {
            Glossaire.Instance.GetCombosData(CmbNumCard, "id_carte", "carte", "status", "Active");
        }

        private void LoadGridControle()
        {
            string field = " nom, postnom, prenom, sexe, adresse, affiliation, " +
                "tel, reseaux, id_carte, matr_client ";
            Glossaire.Instance.GetDatas(GcEnregistrement, field, "t_client");
        }

        private void ClearFields()
        {
            TxtAdresse.Text = String.Empty;
            TxtAffiliation.Text = String.Empty;
            TxtMatricule.Text = String.Empty;
            TxtNom.Text = String.Empty;
            TxtPostnom.Text = String.Empty;
            TxtPrenom.Text = String.Empty;
            TxtReseau.Text = String.Empty;
            TxtSexe.Text = String.Empty;
            TxtTelephone.Text = String.Empty;
            TxtSearchControle.Text = String.Empty;    
            
            TxtSearchControle.Focus();

            BtnSave.Enabled = false;
            BtnDelete.Enabled = false;
        }

        private bool IsNotEmpty()
        {
            if (!string.IsNullOrEmpty(TxtMatricule.Text) && !string.IsNullOrEmpty(CmbNumCard.Text))
            {
                return true;
            }
            else
                return false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty())
            {
                client = new Client
                {
                    IdNFC = CmbNumCard.Text,
                    Matricule = TxtMatricule.Text
                };

                Glossaire.Instance.InsertUpdateClient(client);

                LoadGridControle();
                ClearFields();
            }
            else
            {
                XtraMessageBox.Show("Remplissez tous les champs svp ! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }           
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty())
            {
                /// TODO: Function delete client
            }
        }

        private void GcEnregistrement_DoubleClick(object sender, EventArgs e)
        {
            TxtAdresse.Text = GvEnregistrement.GetFocusedRowCellValue("adresse").ToString();
            TxtAffiliation.Text = GvEnregistrement.GetFocusedRowCellValue("affiliation").ToString();
            TxtMatricule.Text = GvEnregistrement.GetFocusedRowCellValue("matr_client").ToString();
            TxtNom.Text = GvEnregistrement.GetFocusedRowCellValue("nom").ToString();
            TxtPostnom.Text = GvEnregistrement.GetFocusedRowCellValue("postnom").ToString();
            TxtPrenom.Text = GvEnregistrement.GetFocusedRowCellValue("prenom").ToString();
            TxtReseau.Text = GvEnregistrement.GetFocusedRowCellValue("reseaux").ToString();
            TxtSexe.Text = GvEnregistrement.GetFocusedRowCellValue("sexe").ToString();
            TxtTelephone.Text = GvEnregistrement.GetFocusedRowCellValue("tel").ToString();

            BtnSave.Enabled = true;
        }

        
    }
}
