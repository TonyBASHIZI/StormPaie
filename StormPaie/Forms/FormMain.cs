using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace StormPaie.Forms
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Form form = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            form = new FormLogin();
            form.Icon = this.Icon;
            form.ShowDialog();
        }

        private void SelectForms(string name)
        {
            try
            {               
                switch (name)
                {                   
                    case "Enreg":

                        form = new FormEnresitrement();
                        form.MdiParent = this;
                        form.Show();
                        break;

                    case "Recharge":

                        form = new FormRechargement();
                        form.MdiParent = this;
                        form.Show();
                        break;

                    case "Card":

                        this.Cursor = Cursors.WaitCursor;
                        form = new FormCardNFC();
                        form.ShowDialog();
                        this.Cursor = Cursors.Default;
                        break;

                    case "Home":
                        foreach (Form childForm in MdiChildren)
                        {
                            childForm.Close();
                        }
                        PanelAccueil.Visible = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void RibbonButtons_ItemClick(object sender, ItemClickEventArgs e)
        {
            string s = e.Item.Name.Substring(2);
            PanelAccueil.Visible = false;
            SelectForms(s);
        }

        private void NavBarControlItems_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            string s = e.Link.Item.Name.Substring(2);
            PanelAccueil.Visible = false;
            SelectForms(s);
        }
    }
}