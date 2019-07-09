namespace StormPaie.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.LblUser = new DevExpress.XtraBars.BarStaticItem();
            this.BbHome = new DevExpress.XtraBars.BarButtonItem();
            this.BbEnreg = new DevExpress.XtraBars.BarButtonItem();
            this.BbRecharge = new DevExpress.XtraBars.BarButtonItem();
            this.BbCard = new DevExpress.XtraBars.BarButtonItem();
            this.BbApropos = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.tileControl = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.BiHome = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.NbHome = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem1 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.NbEnreg = new DevExpress.XtraNavBar.NavBarItem();
            this.NbRecharge = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.NbCard = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.NbApopos = new DevExpress.XtraNavBar.NavBarItem();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.PanelAccueil = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelAccueil)).BeginInit();
            this.PanelAccueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barStaticItem1,
            this.LblUser,
            this.BbHome,
            this.BbEnreg,
            this.BbRecharge,
            this.BbCard,
            this.BbApropos});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 18;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1048, 146);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Utilisteur : ";
            this.barStaticItem1.Id = 9;
            this.barStaticItem1.ImageOptions.Image = global::StormPaie.Properties.Resources.employee_16x16;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // LblUser
            // 
            this.LblUser.Caption = "Invité";
            this.LblUser.Id = 10;
            this.LblUser.Name = "LblUser";
            // 
            // BbHome
            // 
            this.BbHome.Caption = "Accueil";
            this.BbHome.Id = 11;
            this.BbHome.ImageOptions.LargeImage = global::StormPaie.Properties.Resources.home_32x32;
            this.BbHome.Name = "BbHome";
            this.BbHome.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RibbonButtons_ItemClick);
            // 
            // BbEnreg
            // 
            this.BbEnreg.Caption = "Enregistrement";
            this.BbEnreg.Id = 12;
            this.BbEnreg.ImageOptions.Image = global::StormPaie.Properties.Resources.saveas_16x16;
            this.BbEnreg.ImageOptions.LargeImage = global::StormPaie.Properties.Resources.saveas_32x32;
            this.BbEnreg.Name = "BbEnreg";
            this.BbEnreg.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BbEnreg.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RibbonButtons_ItemClick);
            // 
            // BbRecharge
            // 
            this.BbRecharge.Caption = "Recharge";
            this.BbRecharge.Id = 13;
            this.BbRecharge.ImageOptions.Image = global::StormPaie.Properties.Resources.currency_16x16;
            this.BbRecharge.ImageOptions.LargeImage = global::StormPaie.Properties.Resources.currency_32x32;
            this.BbRecharge.Name = "BbRecharge";
            this.BbRecharge.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BbRecharge.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RibbonButtons_ItemClick);
            // 
            // BbCard
            // 
            this.BbCard.Caption = "Carte NFC";
            this.BbCard.Id = 14;
            this.BbCard.ImageOptions.Image = global::StormPaie.Properties.Resources.editpagehf_16x16;
            this.BbCard.ImageOptions.LargeImage = global::StormPaie.Properties.Resources.editpagehf_32x32;
            this.BbCard.Name = "BbCard";
            this.BbCard.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BbCard.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RibbonButtons_ItemClick);
            // 
            // BbApropos
            // 
            this.BbApropos.Caption = "A propos";
            this.BbApropos.Id = 16;
            this.BbApropos.ImageOptions.Image = global::StormPaie.Properties.Resources.info_16x16;
            this.BbApropos.ImageOptions.LargeImage = global::StormPaie.Properties.Resources.info_32x32;
            this.BbApropos.Name = "BbApropos";
            this.BbApropos.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.BbApropos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RibbonButtons_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Accueil";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.BbHome);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Navigation";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup6});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Formulaire";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.BbHome);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Navigation";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.ItemLinks.Add(this.BbEnreg);
            this.ribbonPageGroup6.ItemLinks.Add(this.BbRecharge);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Formulaires";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Paramètre";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.BbHome);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Navigation";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.BbCard);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Outils";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Aide";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.BbApropos);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "?";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.LblUser);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 628);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1048, 21);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinMaskColor = System.Drawing.Color.Lime;
            this.defaultLookAndFeel1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Lime;
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // tileControl
            // 
            this.tileControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl.Groups.Add(this.tileGroup2);
            this.tileControl.Groups.Add(this.tileGroup3);
            this.tileControl.Location = new System.Drawing.Point(2, 2);
            this.tileControl.Name = "tileControl";
            this.tileControl.ShowText = true;
            this.tileControl.Size = new System.Drawing.Size(849, 478);
            this.tileControl.TabIndex = 3;
            this.tileControl.Text = "Bienvenu";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileGroup3
            // 
            this.tileGroup3.Name = "tileGroup3";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "ribbonPage6";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup4});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.BiHome,
            this.NbEnreg,
            this.NbRecharge,
            this.NbCard,
            this.NbApopos,
            this.navBarSeparatorItem1,
            this.NbHome});
            this.navBarControl1.Location = new System.Drawing.Point(0, 146);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 183;
            this.navBarControl1.Size = new System.Drawing.Size(183, 482);
            this.navBarControl1.TabIndex = 6;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.SkinExplorerBarViewInfoRegistrator();
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Accueil";
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.BiHome)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // BiHome
            // 
            this.BiHome.Caption = "Accueil";
            this.BiHome.Name = "BiHome";
            this.BiHome.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavBarControlItems_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Formulaire";
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.NbHome),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.NbEnreg),
            new DevExpress.XtraNavBar.NavBarItemLink(this.NbRecharge)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // NbHome
            // 
            this.NbHome.Caption = "Accueil";
            this.NbHome.Name = "NbHome";
            this.NbHome.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavBarControlItems_LinkClicked);
            // 
            // navBarSeparatorItem1
            // 
            this.navBarSeparatorItem1.CanDrag = false;
            this.navBarSeparatorItem1.Enabled = false;
            this.navBarSeparatorItem1.Hint = null;
            this.navBarSeparatorItem1.LargeImageIndex = 0;
            this.navBarSeparatorItem1.LargeImageSize = new System.Drawing.Size(0, 0);
            this.navBarSeparatorItem1.Name = "navBarSeparatorItem1";
            this.navBarSeparatorItem1.SmallImageIndex = 0;
            this.navBarSeparatorItem1.SmallImageSize = new System.Drawing.Size(0, 0);
            // 
            // NbEnreg
            // 
            this.NbEnreg.Caption = "Enregistrement";
            this.NbEnreg.Name = "NbEnreg";
            this.NbEnreg.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavBarControlItems_LinkClicked);
            // 
            // NbRecharge
            // 
            this.NbRecharge.Caption = "Recharge";
            this.NbRecharge.Name = "NbRecharge";
            this.NbRecharge.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavBarControlItems_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Paramètre";
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.NbCard)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // NbCard
            // 
            this.NbCard.Caption = "Carte NFC";
            this.NbCard.Name = "NbCard";
            this.NbCard.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavBarControlItems_LinkClicked);
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "Aide";
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.NbApopos)});
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // NbApopos
            // 
            this.NbApopos.Caption = "A propos";
            this.NbApopos.Name = "NbApopos";
            this.NbApopos.LinkPressed += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.NavBarControlItems_LinkClicked);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(183, 146);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(12, 482);
            this.splitterControl1.TabIndex = 7;
            this.splitterControl1.TabStop = false;
            // 
            // PanelAccueil
            // 
            this.PanelAccueil.Controls.Add(this.tileControl);
            this.PanelAccueil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAccueil.Location = new System.Drawing.Point(195, 146);
            this.PanelAccueil.Name = "PanelAccueil";
            this.PanelAccueil.Size = new System.Drawing.Size(853, 482);
            this.PanelAccueil.TabIndex = 8;
            // 
            // FormMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 649);
            this.Controls.Add(this.PanelAccueil);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1050, 650);
            this.Name = "FormMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "STORM Pay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelAccueil)).EndInit();
            this.PanelAccueil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraEditors.TileControl tileControl;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem LblUser;
        private DevExpress.XtraBars.BarButtonItem BbHome;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.BarButtonItem BbEnreg;
        private DevExpress.XtraBars.BarButtonItem BbRecharge;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.BarButtonItem BbCard;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem BbApropos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraNavBar.NavBarItem BiHome;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem NbEnreg;
        private DevExpress.XtraNavBar.NavBarItem NbRecharge;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem NbCard;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarItem NbApopos;
        private DevExpress.XtraNavBar.NavBarItem NbHome;
        private DevExpress.XtraEditors.PanelControl PanelAccueil;
    }
}