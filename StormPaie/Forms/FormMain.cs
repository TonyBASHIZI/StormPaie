using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

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

        private void BarBtnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
    }
}