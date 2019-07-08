﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StormPaie_Lib.Classes;

namespace StormPaie.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnConnection_Click(object sender, EventArgs e)
        {
            if(TxtUsername.Text.Trim()==string.Empty || TxtPassword.Text.ToString().Trim()==string.Empty)
            {
                MessageBox.Show("Veuillez remplir tous les champs !!");
            }
            else
            {
                var result = Glossaire.Instance.retrofitUsers_login(TxtUsername.Text.Trim(), TxtPassword.Text.Trim());
                if (result == true)
                {
                    this.Hide();
                }
                else
                {
                    TxtUsername.Text = "";
                    TxtPassword.Text = "";
                }
            }
        }
    }
}
