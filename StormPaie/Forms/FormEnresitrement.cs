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
            /// TODO: Load id NFC in Combobox
            throw new NotImplementedException();
        }

        private void LoadGridControle()
        {
            /// TODO: Load Clients in the GridControle
            throw new NotImplementedException();
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
