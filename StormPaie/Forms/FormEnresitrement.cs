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
        public FormEnresitrement()
        {
            InitializeComponent();
        }

        private void FormEnresitrement_Load(object sender, EventArgs e)
        {
            //LoadCombos();
            //LoadGridControle();
        }

        private void LoadCombos()
        {
            Glossaire.Instance.GetCombosData(CmbNumCard, "id_carte", "t_client");
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
                /// TODO: Function save client
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (IsNotEmpty())
            {
                /// TODO: Function delete client
            }
        }      
    }
}
