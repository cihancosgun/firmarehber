namespace FirmaRehber
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lblBugun = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.beTema = new DevExpress.XtraBars.BarEditItem();
            this.cmbTema = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 718);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1016, 23);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonText = null;
            this.ribbonControl1.ApplicationCaption = "Perfect Mail";
            this.ribbonControl1.ApplicationDocumentCaption = "Perfect Mail";
            // 
            // 
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.GalleryAnimationLength = 2;
            this.ribbonControl1.GroupAnimationLength = 2;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.lblBugun,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem8,
            this.barButtonItem9,
            this.beTema,
            this.barButtonItem12,
            this.barButtonItem7,
            this.barButtonItem13,
            this.barButtonItem14,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem6,
            this.barButtonItem10});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 32;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Never;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.beTema);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbTema});
            this.ribbonControl1.SelectedPage = this.ribbonPage1;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1016, 142);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ribbonControl1_ItemClick);
            // 
            // lblBugun
            // 
            this.lblBugun.Caption = "16.10.2010 14:41:00";
            this.lblBugun.Id = 0;
            this.lblBugun.Name = "lblBugun";
            this.lblBugun.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Veritabanı Yedekle";
            this.barButtonItem4.Id = 7;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Veritabanı Geri Yükle";
            this.barButtonItem5.Id = 8;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Adres Grupları";
            this.barButtonItem8.Id = 12;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem8.Tag = "frmKisiGrup";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Adresler";
            this.barButtonItem9.Id = 13;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem9.Tag = "frmKisiler";
            // 
            // beTema
            // 
            this.beTema.Caption = "Tema : ";
            this.beTema.Edit = this.cmbTema;
            this.beTema.Id = 16;
            this.beTema.Name = "beTema";
            this.beTema.Width = 150;
            this.beTema.EditValueChanged += new System.EventHandler(this.beTema_EditValueChanged);
            // 
            // cmbTema
            // 
            this.cmbTema.AutoHeight = false;
            this.cmbTema.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTema.Items.AddRange(new object[] {
            "Caramel",
            "Money Twins",
            "Lilian",
            "The Asphalt World",
            "iMaginary",
            "Black",
            "Blue"});
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Yeni Mesaj";
            this.barButtonItem12.Id = 17;
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.Tag = "frmYeniMesaj";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Metin Dosyasından Al";
            this.barButtonItem7.Id = 20;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Excell Dosyasından Al";
            this.barButtonItem13.Id = 21;
            this.barButtonItem13.Name = "barButtonItem13";
            this.barButtonItem13.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem13_ItemClick);
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Excell Dosyasına Ver";
            this.barButtonItem14.Id = 22;
            this.barButtonItem14.Name = "barButtonItem14";
            this.barButtonItem14.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem14_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Firma Kayıt İşlemleri";
            this.barButtonItem1.Id = 27;
            this.barButtonItem1.LargeGlyph = global::FirmaRehber.Properties.Resources.ADD;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.Tag = "frmFirmaTnm";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Firma Alım Bilgileri";
            this.barButtonItem2.Id = 28;
            this.barButtonItem2.LargeGlyph = global::FirmaRehber.Properties.Resources.All_mail;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.Tag = "frmFirmaAlimlar";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Firma Satış Bilgileri";
            this.barButtonItem3.Id = 29;
            this.barButtonItem3.LargeGlyph = global::FirmaRehber.Properties.Resources.document_edit;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.Tag = "frmFirmaSatislar";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Ürünler";
            this.barButtonItem6.Id = 30;
            this.barButtonItem6.LargeGlyph = global::FirmaRehber.Properties.Resources.document_new;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.Tag = "frmUrunTnm";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Hakkında";
            this.barButtonItem10.Id = 31;
            this.barButtonItem10.LargeGlyph = global::FirmaRehber.Properties.Resources.SIGNPOST;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem10_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ana Menü";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowMinimize = false;
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Firma İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowMinimize = false;
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Hakkında";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 741);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "TS Firma Rehberi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarStaticItem lblBugun;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarEditItem beTema;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmbTema;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
    }
}