namespace FirmaRehber.Firma
{
    partial class frmFirmaTnm
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
            System.Windows.Forms.Label logoLabel;
            System.Windows.Forms.Label semtLabel;
            System.Windows.Forms.Label ilceLabel;
            System.Windows.Forms.Label sehirLabel;
            System.Windows.Forms.Label ulkeLabel;
            System.Windows.Forms.Label adresLabel;
            System.Windows.Forms.Label webSiteLabel;
            System.Windows.Forms.Label vergiNoLabel;
            System.Windows.Forms.Label vergiDaireLabel;
            System.Windows.Forms.Label gsmLabel;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label firmaAdLabel;
            System.Windows.Forms.Label etiketlerLabel;
            System.Windows.Forms.Label firmaHakkindaLabel;
            System.Windows.Forms.Label calisanSayisiLabel;
            System.Windows.Forms.Label yillikCiroLabel;
            System.Windows.Forms.Label isletmeTuruLabel;
            System.Windows.Forms.Label kurulusYiliLabel;
            System.Windows.Forms.Label yetkiliPozisyonLabel;
            System.Windows.Forms.Label yetkiliLabel;
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.Windows.Forms.Label ePostaLabel;
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.grdAltSektor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSektor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sektorlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sektorlerDs = new FirmaRehber.sektorlerDs();
            this.grdSektor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSektor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.altSektorlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmaRehberDataSet = new FirmaRehber.FirmaRehberDataSet();
            this.firmalarTableAdapter = new FirmaRehber.FirmaRehberDataSetTableAdapters.FirmalarTableAdapter();
            this.tableAdapterManager = new FirmaRehber.FirmaRehberDataSetTableAdapters.TableAdapterManager();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.ePostaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.firmalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLogoTemizle = new System.Windows.Forms.LinkLabel();
            this.btnLogoSec = new System.Windows.Forms.LinkLabel();
            this.sehirTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.logoPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.semtTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ilceLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ılcelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ilcelerDs = new FirmaRehber.ilcelerDs();
            this.sehirLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.sehirlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sehirlerDs = new FirmaRehber.sehirlerDs();
            this.ulkeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ulkelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ulkelerDs = new FirmaRehber.ulkelerDs();
            this.adresMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.webSiteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.vergiNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.vergiDaireTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gsmTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.faxTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.telefonTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.firmaAdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.calisanSayisiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.yetkiliPozisyonLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.firmadakiPozisyonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yetkiliPozisyon = new FirmaRehber.yetkiliPozisyon();
            this.etiketlerMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.firmaHakkindaMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.yillikCiroLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.yillikCiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yillikCiro = new FirmaRehber.yillikCiro();
            this.isletmeTuruLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ısletmeTuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isletmeTuru = new FirmaRehber.isletmeTuru();
            this.kurulusYiliSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.yetkiliTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnSec = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.firmaSektorlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmaSektorlerDs = new FirmaRehber.FirmaSektorlerDs();
            this.grdFirmaSektor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSektor2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.ulkelerTableAdapter = new FirmaRehber.ulkelerDsTableAdapters.UlkelerTableAdapter();
            this.sehirlerTableAdapter = new FirmaRehber.sehirlerDsTableAdapters.SehirlerTableAdapter();
            this.ilcelerTableAdapter = new FirmaRehber.ilcelerDsTableAdapters.IlcelerTableAdapter();
            this.firmadakiPozisyonTableAdapter = new FirmaRehber.yetkiliPozisyonTableAdapters.FirmadakiPozisyonTableAdapter();
            this.isletmeTuruTableAdapter = new FirmaRehber.isletmeTuruTableAdapters.IsletmeTuruTableAdapter();
            this.yillikCiroTableAdapter = new FirmaRehber.yillikCiroTableAdapters.YillikCiroTableAdapter();
            this.tableAdapterManager1 = new FirmaRehber.sektorlerDsTableAdapters.TableAdapterManager();
            this.sektorlerTableAdapter = new FirmaRehber.sektorlerDsTableAdapters.SektorlerTableAdapter();
            this.altSektorlerTableAdapter = new FirmaRehber.sektorlerDsTableAdapters.AltSektorlerTableAdapter();
            this.firmaSektorlerTableAdapter = new FirmaRehber.FirmaSektorlerDsTableAdapters.FirmaSektorlerTableAdapter();
            logoLabel = new System.Windows.Forms.Label();
            semtLabel = new System.Windows.Forms.Label();
            ilceLabel = new System.Windows.Forms.Label();
            sehirLabel = new System.Windows.Forms.Label();
            ulkeLabel = new System.Windows.Forms.Label();
            adresLabel = new System.Windows.Forms.Label();
            webSiteLabel = new System.Windows.Forms.Label();
            vergiNoLabel = new System.Windows.Forms.Label();
            vergiDaireLabel = new System.Windows.Forms.Label();
            gsmLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            firmaAdLabel = new System.Windows.Forms.Label();
            etiketlerLabel = new System.Windows.Forms.Label();
            firmaHakkindaLabel = new System.Windows.Forms.Label();
            calisanSayisiLabel = new System.Windows.Forms.Label();
            yillikCiroLabel = new System.Windows.Forms.Label();
            isletmeTuruLabel = new System.Windows.Forms.Label();
            kurulusYiliLabel = new System.Windows.Forms.Label();
            yetkiliPozisyonLabel = new System.Windows.Forms.Label();
            yetkiliLabel = new System.Windows.Forms.Label();
            ePostaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).BeginInit();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAltSektor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sektorlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sektorlerDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSektor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altSektorlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaRehberDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePostaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semtTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilceLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ılcelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilcelerDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulkeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulkelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulkelerDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webSiteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vergiNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vergiDaireTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsmTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faxTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaAdTextEdit.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calisanSayisiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yetkiliPozisyonLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmadakiPozisyonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yetkiliPozisyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etiketlerMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaHakkindaMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yillikCiroLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yillikCiroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yillikCiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isletmeTuruLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ısletmeTuruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isletmeTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurulusYiliSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yetkiliTextEdit.Properties)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaSektorlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaSektorlerDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFirmaSektor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Size = new System.Drawing.Size(262, 739);
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.xtraTabControl1);
            this.Panel.Size = new System.Drawing.Size(563, 739);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Size = new System.Drawing.Size(830, 739);
            this.splitContainerControl1.SplitterPosition = 563;
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Location = new System.Drawing.Point(343, 18);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new System.Drawing.Size(34, 13);
            logoLabel.TabIndex = 66;
            logoLabel.Text = "Logo:";
            // 
            // semtLabel
            // 
            semtLabel.AutoSize = true;
            semtLabel.Location = new System.Drawing.Point(36, 379);
            semtLabel.Name = "semtLabel";
            semtLabel.Size = new System.Drawing.Size(35, 13);
            semtLabel.TabIndex = 64;
            semtLabel.Text = "Semt:";
            // 
            // ilceLabel
            // 
            ilceLabel.AutoSize = true;
            ilceLabel.Location = new System.Drawing.Point(43, 353);
            ilceLabel.Name = "ilceLabel";
            ilceLabel.Size = new System.Drawing.Size(28, 13);
            ilceLabel.TabIndex = 62;
            ilceLabel.Text = "Ilce:";
            // 
            // sehirLabel
            // 
            sehirLabel.AutoSize = true;
            sehirLabel.Location = new System.Drawing.Point(36, 327);
            sehirLabel.Name = "sehirLabel";
            sehirLabel.Size = new System.Drawing.Size(35, 13);
            sehirLabel.TabIndex = 60;
            sehirLabel.Text = "Sehir:";
            // 
            // ulkeLabel
            // 
            ulkeLabel.AutoSize = true;
            ulkeLabel.Location = new System.Drawing.Point(40, 301);
            ulkeLabel.Name = "ulkeLabel";
            ulkeLabel.Size = new System.Drawing.Size(31, 13);
            ulkeLabel.TabIndex = 58;
            ulkeLabel.Text = "Ulke:";
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.Location = new System.Drawing.Point(32, 199);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new System.Drawing.Size(39, 13);
            adresLabel.TabIndex = 56;
            adresLabel.Text = "Adres:";
            // 
            // webSiteLabel
            // 
            webSiteLabel.AutoSize = true;
            webSiteLabel.Location = new System.Drawing.Point(17, 173);
            webSiteLabel.Name = "webSiteLabel";
            webSiteLabel.Size = new System.Drawing.Size(54, 13);
            webSiteLabel.TabIndex = 54;
            webSiteLabel.Text = "Web Site:";
            // 
            // vergiNoLabel
            // 
            vergiNoLabel.AutoSize = true;
            vergiNoLabel.Location = new System.Drawing.Point(20, 147);
            vergiNoLabel.Name = "vergiNoLabel";
            vergiNoLabel.Size = new System.Drawing.Size(51, 13);
            vergiNoLabel.TabIndex = 52;
            vergiNoLabel.Text = "Vergi No:";
            // 
            // vergiDaireLabel
            // 
            vergiDaireLabel.AutoSize = true;
            vergiDaireLabel.Location = new System.Drawing.Point(8, 121);
            vergiDaireLabel.Name = "vergiDaireLabel";
            vergiDaireLabel.Size = new System.Drawing.Size(63, 13);
            vergiDaireLabel.TabIndex = 50;
            vergiDaireLabel.Text = "Vergi Daire:";
            // 
            // gsmLabel
            // 
            gsmLabel.AutoSize = true;
            gsmLabel.Location = new System.Drawing.Point(40, 95);
            gsmLabel.Name = "gsmLabel";
            gsmLabel.Size = new System.Drawing.Size(31, 13);
            gsmLabel.TabIndex = 48;
            gsmLabel.Text = "Gsm:";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(42, 69);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(29, 13);
            faxLabel.TabIndex = 46;
            faxLabel.Text = "Fax:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(24, 43);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(47, 13);
            telefonLabel.TabIndex = 44;
            telefonLabel.Text = "Telefon:";
            // 
            // firmaAdLabel
            // 
            firmaAdLabel.AutoSize = true;
            firmaAdLabel.Location = new System.Drawing.Point(18, 18);
            firmaAdLabel.Name = "firmaAdLabel";
            firmaAdLabel.Size = new System.Drawing.Size(53, 13);
            firmaAdLabel.TabIndex = 42;
            firmaAdLabel.Text = "Firma Ad:";
            // 
            // etiketlerLabel
            // 
            etiketlerLabel.AutoSize = true;
            etiketlerLabel.Location = new System.Drawing.Point(41, 279);
            etiketlerLabel.Name = "etiketlerLabel";
            etiketlerLabel.Size = new System.Drawing.Size(50, 13);
            etiketlerLabel.TabIndex = 54;
            etiketlerLabel.Text = "Etiketler:";
            // 
            // firmaHakkindaLabel
            // 
            firmaHakkindaLabel.AutoSize = true;
            firmaHakkindaLabel.Location = new System.Drawing.Point(8, 177);
            firmaHakkindaLabel.Name = "firmaHakkindaLabel";
            firmaHakkindaLabel.Size = new System.Drawing.Size(83, 13);
            firmaHakkindaLabel.TabIndex = 52;
            firmaHakkindaLabel.Text = "Firma Hakkinda:";
            // 
            // calisanSayisiLabel
            // 
            calisanSayisiLabel.AutoSize = true;
            calisanSayisiLabel.Location = new System.Drawing.Point(16, 151);
            calisanSayisiLabel.Name = "calisanSayisiLabel";
            calisanSayisiLabel.Size = new System.Drawing.Size(75, 13);
            calisanSayisiLabel.TabIndex = 50;
            calisanSayisiLabel.Text = "Calisan Sayisi:";
            // 
            // yillikCiroLabel
            // 
            yillikCiroLabel.AutoSize = true;
            yillikCiroLabel.Location = new System.Drawing.Point(39, 125);
            yillikCiroLabel.Name = "yillikCiroLabel";
            yillikCiroLabel.Size = new System.Drawing.Size(52, 13);
            yillikCiroLabel.TabIndex = 48;
            yillikCiroLabel.Text = "Yillik Ciro:";
            // 
            // isletmeTuruLabel
            // 
            isletmeTuruLabel.AutoSize = true;
            isletmeTuruLabel.Location = new System.Drawing.Point(20, 99);
            isletmeTuruLabel.Name = "isletmeTuruLabel";
            isletmeTuruLabel.Size = new System.Drawing.Size(71, 13);
            isletmeTuruLabel.TabIndex = 46;
            isletmeTuruLabel.Text = "Isletme Turu:";
            // 
            // kurulusYiliLabel
            // 
            kurulusYiliLabel.AutoSize = true;
            kurulusYiliLabel.Location = new System.Drawing.Point(30, 73);
            kurulusYiliLabel.Name = "kurulusYiliLabel";
            kurulusYiliLabel.Size = new System.Drawing.Size(61, 13);
            kurulusYiliLabel.TabIndex = 44;
            kurulusYiliLabel.Text = "Kurulus Yili:";
            // 
            // yetkiliPozisyonLabel
            // 
            yetkiliPozisyonLabel.AutoSize = true;
            yetkiliPozisyonLabel.Location = new System.Drawing.Point(8, 47);
            yetkiliPozisyonLabel.Name = "yetkiliPozisyonLabel";
            yetkiliPozisyonLabel.Size = new System.Drawing.Size(83, 13);
            yetkiliPozisyonLabel.TabIndex = 42;
            yetkiliPozisyonLabel.Text = "Yetkili Pozisyon:";
            // 
            // yetkiliLabel
            // 
            yetkiliLabel.AutoSize = true;
            yetkiliLabel.Location = new System.Drawing.Point(53, 21);
            yetkiliLabel.Name = "yetkiliLabel";
            yetkiliLabel.Size = new System.Drawing.Size(38, 13);
            yetkiliLabel.TabIndex = 40;
            yetkiliLabel.Text = "Yetkili:";
            // 
            // grdAltSektor
            // 
            this.grdAltSektor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSektor1});
            this.grdAltSektor.GridControl = this.gridControl1;
            this.grdAltSektor.Name = "grdAltSektor";
            this.grdAltSektor.OptionsBehavior.Editable = false;
            this.grdAltSektor.OptionsView.EnableAppearanceEvenRow = true;
            this.grdAltSektor.OptionsView.EnableAppearanceOddRow = true;
            this.grdAltSektor.OptionsView.ShowAutoFilterRow = true;
            this.grdAltSektor.OptionsView.ShowGroupPanel = false;
            this.grdAltSektor.OptionsView.ShowViewCaption = true;
            this.grdAltSektor.ViewCaption = "Alt Sektörler";
            // 
            // colSektor1
            // 
            this.colSektor1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colSektor1.AppearanceHeader.Options.UseFont = true;
            this.colSektor1.AppearanceHeader.Options.UseTextOptions = true;
            this.colSektor1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSektor1.Caption = "Sektör";
            this.colSektor1.FieldName = "AltSektor";
            this.colSektor1.Name = "colSektor1";
            this.colSektor1.Visible = true;
            this.colSektor1.VisibleIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sektorlerBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.grdAltSektor;
            gridLevelNode1.RelationName = "SektorAltSektor";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(2, 22);
            this.gridControl1.MainView = this.grdSektor;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(549, 217);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdSektor,
            this.grdAltSektor});
            // 
            // sektorlerBindingSource
            // 
            this.sektorlerBindingSource.DataMember = "Sektorler";
            this.sektorlerBindingSource.DataSource = this.sektorlerDs;
            // 
            // sektorlerDs
            // 
            this.sektorlerDs.DataSetName = "sektorlerDs";
            this.sektorlerDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdSektor
            // 
            this.grdSektor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSektor});
            this.grdSektor.GridControl = this.gridControl1;
            this.grdSektor.Name = "grdSektor";
            this.grdSektor.OptionsBehavior.Editable = false;
            this.grdSektor.OptionsView.EnableAppearanceEvenRow = true;
            this.grdSektor.OptionsView.EnableAppearanceOddRow = true;
            this.grdSektor.OptionsView.ShowAutoFilterRow = true;
            this.grdSektor.OptionsView.ShowGroupPanel = false;
            this.grdSektor.OptionsView.ShowViewCaption = true;
            this.grdSektor.ViewCaption = "Sektörler";
            // 
            // colSektor
            // 
            this.colSektor.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colSektor.AppearanceHeader.Options.UseFont = true;
            this.colSektor.AppearanceHeader.Options.UseTextOptions = true;
            this.colSektor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSektor.Caption = "Sektör";
            this.colSektor.FieldName = "Sektor";
            this.colSektor.Name = "colSektor";
            this.colSektor.Visible = true;
            this.colSektor.VisibleIndex = 0;
            // 
            // ePostaLabel
            // 
            ePostaLabel.AutoSize = true;
            ePostaLabel.Location = new System.Drawing.Point(23, 405);
            ePostaLabel.Name = "ePostaLabel";
            ePostaLabel.Size = new System.Drawing.Size(48, 13);
            ePostaLabel.TabIndex = 70;
            ePostaLabel.Text = "E-Posta:";
            // 
            // altSektorlerBindingSource
            // 
            this.altSektorlerBindingSource.DataMember = "AltSektorler";
            this.altSektorlerBindingSource.DataSource = this.sektorlerDs;
            // 
            // firmaRehberDataSet
            // 
            this.firmaRehberDataSet.DataSetName = "FirmaRehberDataSet";
            this.firmaRehberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmalarTableAdapter
            // 
            this.firmalarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FirmalarTableAdapter = this.firmalarTableAdapter;
            this.tableAdapterManager.UpdateOrder = FirmaRehber.FirmaRehberDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(559, 735);
            this.xtraTabControl1.TabIndex = 40;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AutoScroll = true;
            this.xtraTabPage1.Controls.Add(ePostaLabel);
            this.xtraTabPage1.Controls.Add(this.ePostaTextEdit);
            this.xtraTabPage1.Controls.Add(this.btnLogoTemizle);
            this.xtraTabPage1.Controls.Add(this.btnLogoSec);
            this.xtraTabPage1.Controls.Add(this.sehirTextEdit);
            this.xtraTabPage1.Controls.Add(logoLabel);
            this.xtraTabPage1.Controls.Add(this.logoPictureEdit);
            this.xtraTabPage1.Controls.Add(semtLabel);
            this.xtraTabPage1.Controls.Add(this.semtTextEdit);
            this.xtraTabPage1.Controls.Add(ilceLabel);
            this.xtraTabPage1.Controls.Add(this.ilceLookUpEdit);
            this.xtraTabPage1.Controls.Add(sehirLabel);
            this.xtraTabPage1.Controls.Add(this.sehirLookUpEdit);
            this.xtraTabPage1.Controls.Add(ulkeLabel);
            this.xtraTabPage1.Controls.Add(this.ulkeLookUpEdit);
            this.xtraTabPage1.Controls.Add(adresLabel);
            this.xtraTabPage1.Controls.Add(this.adresMemoEdit);
            this.xtraTabPage1.Controls.Add(webSiteLabel);
            this.xtraTabPage1.Controls.Add(this.webSiteTextEdit);
            this.xtraTabPage1.Controls.Add(vergiNoLabel);
            this.xtraTabPage1.Controls.Add(this.vergiNoTextEdit);
            this.xtraTabPage1.Controls.Add(vergiDaireLabel);
            this.xtraTabPage1.Controls.Add(this.vergiDaireTextEdit);
            this.xtraTabPage1.Controls.Add(gsmLabel);
            this.xtraTabPage1.Controls.Add(this.gsmTextEdit);
            this.xtraTabPage1.Controls.Add(faxLabel);
            this.xtraTabPage1.Controls.Add(this.faxTextEdit);
            this.xtraTabPage1.Controls.Add(telefonLabel);
            this.xtraTabPage1.Controls.Add(this.telefonTextEdit);
            this.xtraTabPage1.Controls.Add(firmaAdLabel);
            this.xtraTabPage1.Controls.Add(this.firmaAdTextEdit);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(553, 708);
            this.xtraTabPage1.Text = "Firma Bilgileri";
            // 
            // ePostaTextEdit
            // 
            this.ePostaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "EPosta", true));
            this.ePostaTextEdit.Location = new System.Drawing.Point(77, 402);
            this.ePostaTextEdit.MenuManager = this.barManager1;
            this.ePostaTextEdit.Name = "ePostaTextEdit";
            this.ePostaTextEdit.Size = new System.Drawing.Size(300, 20);
            this.ePostaTextEdit.TabIndex = 71;
            // 
            // firmalarBindingSource
            // 
            this.firmalarBindingSource.DataMember = "Firmalar";
            this.firmalarBindingSource.DataSource = this.firmaRehberDataSet;
            // 
            // btnLogoTemizle
            // 
            this.btnLogoTemizle.AutoSize = true;
            this.btnLogoTemizle.Location = new System.Drawing.Point(436, 163);
            this.btnLogoTemizle.Name = "btnLogoTemizle";
            this.btnLogoTemizle.Size = new System.Drawing.Size(68, 13);
            this.btnLogoTemizle.TabIndex = 70;
            this.btnLogoTemizle.TabStop = true;
            this.btnLogoTemizle.Text = "Logo Temizle";
            this.btnLogoTemizle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnLogoTemizle_LinkClicked);
            // 
            // btnLogoSec
            // 
            this.btnLogoSec.AutoSize = true;
            this.btnLogoSec.Location = new System.Drawing.Point(380, 163);
            this.btnLogoSec.Name = "btnLogoSec";
            this.btnLogoSec.Size = new System.Drawing.Size(50, 13);
            this.btnLogoSec.TabIndex = 69;
            this.btnLogoSec.TabStop = true;
            this.btnLogoSec.Text = "Logo Seç";
            this.btnLogoSec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnLogoSec_LinkClicked);
            // 
            // sehirTextEdit
            // 
            this.sehirTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "Sehir", true));
            this.sehirTextEdit.Location = new System.Drawing.Point(248, 324);
            this.sehirTextEdit.MenuManager = this.barManager1;
            this.sehirTextEdit.Name = "sehirTextEdit";
            this.sehirTextEdit.Size = new System.Drawing.Size(129, 20);
            this.sehirTextEdit.TabIndex = 68;
            // 
            // logoPictureEdit
            // 
            this.logoPictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "Logo", true));
            this.logoPictureEdit.Location = new System.Drawing.Point(383, 15);
            this.logoPictureEdit.MenuManager = this.barManager1;
            this.logoPictureEdit.Name = "logoPictureEdit";
            this.logoPictureEdit.Size = new System.Drawing.Size(167, 145);
            this.logoPictureEdit.TabIndex = 67;
            // 
            // semtTextEdit
            // 
            this.semtTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "Semt", true));
            this.semtTextEdit.Location = new System.Drawing.Point(77, 376);
            this.semtTextEdit.MenuManager = this.barManager1;
            this.semtTextEdit.Name = "semtTextEdit";
            this.semtTextEdit.Size = new System.Drawing.Size(165, 20);
            this.semtTextEdit.TabIndex = 65;
            // 
            // ilceLookUpEdit
            // 
            this.ilceLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "Ilce", true));
            this.ilceLookUpEdit.Location = new System.Drawing.Point(77, 350);
            this.ilceLookUpEdit.Name = "ilceLookUpEdit";
            this.ilceLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.ilceLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ilce", "Ilce", 27, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ilceLookUpEdit.Properties.DataSource = this.ılcelerBindingSource;
            this.ilceLookUpEdit.Properties.DisplayMember = "Ilce";
            this.ilceLookUpEdit.Properties.ValueMember = "Ilce";
            this.ilceLookUpEdit.Size = new System.Drawing.Size(165, 20);
            this.ilceLookUpEdit.TabIndex = 63;
            this.ilceLookUpEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ilceLookUpEdit_ButtonClick);
            // 
            // ılcelerBindingSource
            // 
            this.ılcelerBindingSource.DataMember = "Ilceler";
            this.ılcelerBindingSource.DataSource = this.ilcelerDs;
            // 
            // ilcelerDs
            // 
            this.ilcelerDs.DataSetName = "ilcelerDs";
            this.ilcelerDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sehirLookUpEdit
            // 
            this.sehirLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "Sehir", true));
            this.sehirLookUpEdit.Location = new System.Drawing.Point(77, 324);
            this.sehirLookUpEdit.Name = "sehirLookUpEdit";
            this.sehirLookUpEdit.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.sehirLookUpEdit.Properties.Appearance.Options.UseBackColor = true;
            this.sehirLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.sehirLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sehir", "Sehir", 34, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.sehirLookUpEdit.Properties.DataSource = this.sehirlerBindingSource;
            this.sehirLookUpEdit.Properties.DisplayMember = "Sehir";
            this.sehirLookUpEdit.Properties.ValueMember = "Sehir";
            this.sehirLookUpEdit.Size = new System.Drawing.Size(165, 20);
            this.sehirLookUpEdit.TabIndex = 61;
            this.sehirLookUpEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.sehirLookUpEdit_ButtonClick);
            // 
            // sehirlerBindingSource
            // 
            this.sehirlerBindingSource.DataMember = "Sehirler";
            this.sehirlerBindingSource.DataSource = this.sehirlerDs;
            // 
            // sehirlerDs
            // 
            this.sehirlerDs.DataSetName = "sehirlerDs";
            this.sehirlerDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ulkeLookUpEdit
            // 
            this.ulkeLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "Ulke", true));
            this.ulkeLookUpEdit.Location = new System.Drawing.Point(77, 298);
            this.ulkeLookUpEdit.Name = "ulkeLookUpEdit";
            this.ulkeLookUpEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ulkeLookUpEdit.Properties.Appearance.Options.UseBackColor = true;
            this.ulkeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.ulkeLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ADI", "ADI", 28, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ulkeLookUpEdit.Properties.DataSource = this.ulkelerBindingSource;
            this.ulkeLookUpEdit.Properties.DisplayMember = "ADI";
            this.ulkeLookUpEdit.Properties.ValueMember = "ADI";
            this.ulkeLookUpEdit.Size = new System.Drawing.Size(165, 20);
            this.ulkeLookUpEdit.TabIndex = 59;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Zorunlu.";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.ValidationProvider.SetValidationRule(this.ulkeLookUpEdit, conditionValidationRule1);
            this.ulkeLookUpEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ulkeLookUpEdit_ButtonClick);
            // 
            // ulkelerBindingSource
            // 
            this.ulkelerBindingSource.DataMember = "Ulkeler";
            this.ulkelerBindingSource.DataSource = this.ulkelerDs;
            // 
            // ulkelerDs
            // 
            this.ulkelerDs.DataSetName = "ulkelerDs";
            this.ulkelerDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adresMemoEdit
            // 
            this.adresMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "Adres", true));
            this.adresMemoEdit.Location = new System.Drawing.Point(77, 196);
            this.adresMemoEdit.MenuManager = this.barManager1;
            this.adresMemoEdit.Name = "adresMemoEdit";
            this.adresMemoEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.adresMemoEdit.Properties.Appearance.Options.UseBackColor = true;
            this.adresMemoEdit.Size = new System.Drawing.Size(245, 96);
            this.adresMemoEdit.TabIndex = 57;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Zorunlu.";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.ValidationProvider.SetValidationRule(this.adresMemoEdit, conditionValidationRule2);
            // 
            // webSiteTextEdit
            // 
            this.webSiteTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "WebSite", true));
            this.webSiteTextEdit.Location = new System.Drawing.Point(77, 170);
            this.webSiteTextEdit.MenuManager = this.barManager1;
            this.webSiteTextEdit.Name = "webSiteTextEdit";
            this.webSiteTextEdit.Size = new System.Drawing.Size(245, 20);
            this.webSiteTextEdit.TabIndex = 55;
            // 
            // vergiNoTextEdit
            // 
            this.vergiNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "VergiNo", true));
            this.vergiNoTextEdit.Location = new System.Drawing.Point(77, 144);
            this.vergiNoTextEdit.MenuManager = this.barManager1;
            this.vergiNoTextEdit.Name = "vergiNoTextEdit";
            this.vergiNoTextEdit.Size = new System.Drawing.Size(100, 20);
            this.vergiNoTextEdit.TabIndex = 53;
            // 
            // vergiDaireTextEdit
            // 
            this.vergiDaireTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "VergiDaire", true));
            this.vergiDaireTextEdit.Location = new System.Drawing.Point(77, 118);
            this.vergiDaireTextEdit.MenuManager = this.barManager1;
            this.vergiDaireTextEdit.Name = "vergiDaireTextEdit";
            this.vergiDaireTextEdit.Size = new System.Drawing.Size(100, 20);
            this.vergiDaireTextEdit.TabIndex = 51;
            // 
            // gsmTextEdit
            // 
            this.gsmTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "Gsm", true));
            this.gsmTextEdit.Location = new System.Drawing.Point(77, 92);
            this.gsmTextEdit.MenuManager = this.barManager1;
            this.gsmTextEdit.Name = "gsmTextEdit";
            this.gsmTextEdit.Properties.Mask.EditMask = "(\\d?\\d?\\d?)\\d\\d\\d-\\d\\d\\d\\d";
            this.gsmTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.gsmTextEdit.Size = new System.Drawing.Size(100, 20);
            this.gsmTextEdit.TabIndex = 49;
            // 
            // faxTextEdit
            // 
            this.faxTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "Fax", true));
            this.faxTextEdit.Location = new System.Drawing.Point(77, 66);
            this.faxTextEdit.MenuManager = this.barManager1;
            this.faxTextEdit.Name = "faxTextEdit";
            this.faxTextEdit.Properties.Mask.EditMask = "(\\d?\\d?\\d?)\\d\\d\\d-\\d\\d\\d\\d";
            this.faxTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.faxTextEdit.Size = new System.Drawing.Size(100, 20);
            this.faxTextEdit.TabIndex = 47;
            // 
            // telefonTextEdit
            // 
            this.telefonTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "Telefon", true));
            this.telefonTextEdit.Location = new System.Drawing.Point(77, 40);
            this.telefonTextEdit.MenuManager = this.barManager1;
            this.telefonTextEdit.Name = "telefonTextEdit";
            this.telefonTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.telefonTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.telefonTextEdit.Properties.Mask.EditMask = "(\\d?\\d?\\d?)\\d\\d\\d-\\d\\d\\d\\d";
            this.telefonTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.telefonTextEdit.Size = new System.Drawing.Size(100, 20);
            this.telefonTextEdit.TabIndex = 45;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Zorunlu.";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.ValidationProvider.SetValidationRule(this.telefonTextEdit, conditionValidationRule3);
            // 
            // firmaAdTextEdit
            // 
            this.firmaAdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "FirmaAd", true));
            this.firmaAdTextEdit.Location = new System.Drawing.Point(77, 15);
            this.firmaAdTextEdit.MenuManager = this.barManager1;
            this.firmaAdTextEdit.Name = "firmaAdTextEdit";
            this.firmaAdTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.firmaAdTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.firmaAdTextEdit.Size = new System.Drawing.Size(245, 20);
            this.firmaAdTextEdit.TabIndex = 43;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Zorunlu.";
            conditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.ValidationProvider.SetValidationRule(this.firmaAdTextEdit, conditionValidationRule4);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.calisanSayisiTextEdit);
            this.xtraTabPage2.Controls.Add(this.yetkiliPozisyonLookUpEdit);
            this.xtraTabPage2.Controls.Add(etiketlerLabel);
            this.xtraTabPage2.Controls.Add(this.etiketlerMemoEdit);
            this.xtraTabPage2.Controls.Add(firmaHakkindaLabel);
            this.xtraTabPage2.Controls.Add(this.firmaHakkindaMemoEdit);
            this.xtraTabPage2.Controls.Add(calisanSayisiLabel);
            this.xtraTabPage2.Controls.Add(yillikCiroLabel);
            this.xtraTabPage2.Controls.Add(this.yillikCiroLookUpEdit);
            this.xtraTabPage2.Controls.Add(isletmeTuruLabel);
            this.xtraTabPage2.Controls.Add(this.isletmeTuruLookUpEdit);
            this.xtraTabPage2.Controls.Add(kurulusYiliLabel);
            this.xtraTabPage2.Controls.Add(this.kurulusYiliSpinEdit);
            this.xtraTabPage2.Controls.Add(yetkiliPozisyonLabel);
            this.xtraTabPage2.Controls.Add(yetkiliLabel);
            this.xtraTabPage2.Controls.Add(this.yetkiliTextEdit);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(553, 708);
            this.xtraTabPage2.Text = "Firma Hakkında";
            // 
            // calisanSayisiTextEdit
            // 
            this.calisanSayisiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "CalisanSayisi", true));
            this.calisanSayisiTextEdit.Location = new System.Drawing.Point(97, 148);
            this.calisanSayisiTextEdit.MenuManager = this.barManager1;
            this.calisanSayisiTextEdit.Name = "calisanSayisiTextEdit";
            this.calisanSayisiTextEdit.Size = new System.Drawing.Size(82, 20);
            this.calisanSayisiTextEdit.TabIndex = 50;
            // 
            // yetkiliPozisyonLookUpEdit
            // 
            this.yetkiliPozisyonLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "YetkiliPozisyon", true));
            this.yetkiliPozisyonLookUpEdit.Location = new System.Drawing.Point(97, 44);
            this.yetkiliPozisyonLookUpEdit.Name = "yetkiliPozisyonLookUpEdit";
            this.yetkiliPozisyonLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.yetkiliPozisyonLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FirmadakiPozisyon", "Firmadaki Pozisyon", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.yetkiliPozisyonLookUpEdit.Properties.DataSource = this.firmadakiPozisyonBindingSource;
            this.yetkiliPozisyonLookUpEdit.Properties.DisplayMember = "FirmadakiPozisyon";
            this.yetkiliPozisyonLookUpEdit.Properties.ValueMember = "FirmadakiPozisyon";
            this.yetkiliPozisyonLookUpEdit.Size = new System.Drawing.Size(245, 20);
            this.yetkiliPozisyonLookUpEdit.TabIndex = 56;
            this.yetkiliPozisyonLookUpEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.yetkiliPozisyonLookUpEdit_ButtonClick);
            // 
            // firmadakiPozisyonBindingSource
            // 
            this.firmadakiPozisyonBindingSource.DataMember = "FirmadakiPozisyon";
            this.firmadakiPozisyonBindingSource.DataSource = this.yetkiliPozisyon;
            // 
            // yetkiliPozisyon
            // 
            this.yetkiliPozisyon.DataSetName = "yetkiliPozisyon";
            this.yetkiliPozisyon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etiketlerMemoEdit
            // 
            this.etiketlerMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "Etiketler", true));
            this.etiketlerMemoEdit.Location = new System.Drawing.Point(97, 276);
            this.etiketlerMemoEdit.MenuManager = this.barManager1;
            this.etiketlerMemoEdit.Name = "etiketlerMemoEdit";
            this.etiketlerMemoEdit.Size = new System.Drawing.Size(431, 72);
            this.etiketlerMemoEdit.TabIndex = 55;
            // 
            // firmaHakkindaMemoEdit
            // 
            this.firmaHakkindaMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "FirmaHakkinda", true));
            this.firmaHakkindaMemoEdit.Location = new System.Drawing.Point(97, 174);
            this.firmaHakkindaMemoEdit.MenuManager = this.barManager1;
            this.firmaHakkindaMemoEdit.Name = "firmaHakkindaMemoEdit";
            this.firmaHakkindaMemoEdit.Size = new System.Drawing.Size(431, 96);
            this.firmaHakkindaMemoEdit.TabIndex = 53;
            // 
            // yillikCiroLookUpEdit
            // 
            this.yillikCiroLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "YillikCiro", true));
            this.yillikCiroLookUpEdit.Location = new System.Drawing.Point(97, 122);
            this.yillikCiroLookUpEdit.Name = "yillikCiroLookUpEdit";
            this.yillikCiroLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.yillikCiroLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("YillikCiro", "Yillik Ciro", 51, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.yillikCiroLookUpEdit.Properties.DataSource = this.yillikCiroBindingSource;
            this.yillikCiroLookUpEdit.Properties.DisplayMember = "YillikCiro";
            this.yillikCiroLookUpEdit.Properties.ValueMember = "YillikCiro";
            this.yillikCiroLookUpEdit.Size = new System.Drawing.Size(165, 20);
            this.yillikCiroLookUpEdit.TabIndex = 49;
            this.yillikCiroLookUpEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.yillikCiroLookUpEdit_ButtonClick);
            // 
            // yillikCiroBindingSource
            // 
            this.yillikCiroBindingSource.DataMember = "YillikCiro";
            this.yillikCiroBindingSource.DataSource = this.yillikCiro;
            // 
            // yillikCiro
            // 
            this.yillikCiro.DataSetName = "yillikCiro";
            this.yillikCiro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // isletmeTuruLookUpEdit
            // 
            this.isletmeTuruLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "IsletmeTuru", true));
            this.isletmeTuruLookUpEdit.Location = new System.Drawing.Point(97, 96);
            this.isletmeTuruLookUpEdit.Name = "isletmeTuruLookUpEdit";
            this.isletmeTuruLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.isletmeTuruLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("IsletmeTuru", "Isletme Turu", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.isletmeTuruLookUpEdit.Properties.DataSource = this.ısletmeTuruBindingSource;
            this.isletmeTuruLookUpEdit.Properties.DisplayMember = "IsletmeTuru";
            this.isletmeTuruLookUpEdit.Properties.ValueMember = "IsletmeTuru";
            this.isletmeTuruLookUpEdit.Size = new System.Drawing.Size(165, 20);
            this.isletmeTuruLookUpEdit.TabIndex = 47;
            this.isletmeTuruLookUpEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.isletmeTuruLookUpEdit_ButtonClick);
            // 
            // ısletmeTuruBindingSource
            // 
            this.ısletmeTuruBindingSource.DataMember = "IsletmeTuru";
            this.ısletmeTuruBindingSource.DataSource = this.isletmeTuru;
            // 
            // isletmeTuru
            // 
            this.isletmeTuru.DataSetName = "isletmeTuru";
            this.isletmeTuru.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kurulusYiliSpinEdit
            // 
            this.kurulusYiliSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "KurulusYili", true));
            this.kurulusYiliSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.kurulusYiliSpinEdit.Location = new System.Drawing.Point(97, 70);
            this.kurulusYiliSpinEdit.MenuManager = this.barManager1;
            this.kurulusYiliSpinEdit.Name = "kurulusYiliSpinEdit";
            this.kurulusYiliSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.kurulusYiliSpinEdit.Properties.IsFloatValue = false;
            this.kurulusYiliSpinEdit.Properties.Mask.EditMask = "N00";
            this.kurulusYiliSpinEdit.Size = new System.Drawing.Size(82, 20);
            this.kurulusYiliSpinEdit.TabIndex = 45;
            // 
            // yetkiliTextEdit
            // 
            this.yetkiliTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmalarBindingSource, "Yetkili", true));
            this.yetkiliTextEdit.Location = new System.Drawing.Point(97, 18);
            this.yetkiliTextEdit.MenuManager = this.barManager1;
            this.yetkiliTextEdit.Name = "yetkiliTextEdit";
            this.yetkiliTextEdit.Size = new System.Drawing.Size(245, 20);
            this.yetkiliTextEdit.TabIndex = 41;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.splitContainerControl2);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(553, 708);
            this.xtraTabPage3.Text = "Faaliyet Alanları";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl2);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.gridControl2);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(553, 708);
            this.splitContainerControl2.SplitterPosition = 290;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Controls.Add(this.panelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(553, 290);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Sektörler";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.btnSil);
            this.panelControl1.Controls.Add(this.btnSec);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(2, 239);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(549, 49);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton1.Image = global::FirmaRehber.Properties.Resources.disk_blue;
            this.simpleButton1.Location = new System.Drawing.Point(309, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(238, 45);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Sektör Tanımlama";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSil.Image = global::FirmaRehber.Properties.Resources.DELETE2;
            this.btnSil.Location = new System.Drawing.Point(96, 2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 45);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Si&l";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSec
            // 
            this.btnSec.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSec.Appearance.Options.UseFont = true;
            this.btnSec.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSec.Image = global::FirmaRehber.Properties.Resources.ADD1;
            this.btnSec.Location = new System.Drawing.Point(2, 2);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(94, 45);
            this.btnSec.TabIndex = 0;
            this.btnSec.Text = "&Seç";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.firmaSektorlerBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.grdFirmaSektor;
            this.gridControl2.MenuManager = this.barManager1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(553, 413);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdFirmaSektor});
            // 
            // firmaSektorlerBindingSource
            // 
            this.firmaSektorlerBindingSource.DataMember = "FirmaSektorler";
            this.firmaSektorlerBindingSource.DataSource = this.firmaSektorlerDs;
            // 
            // firmaSektorlerDs
            // 
            this.firmaSektorlerDs.DataSetName = "FirmaSektorlerDs";
            this.firmaSektorlerDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdFirmaSektor
            // 
            this.grdFirmaSektor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSektor2});
            this.grdFirmaSektor.GridControl = this.gridControl2;
            this.grdFirmaSektor.Name = "grdFirmaSektor";
            this.grdFirmaSektor.OptionsBehavior.Editable = false;
            this.grdFirmaSektor.OptionsView.EnableAppearanceEvenRow = true;
            this.grdFirmaSektor.OptionsView.EnableAppearanceOddRow = true;
            this.grdFirmaSektor.OptionsView.ShowAutoFilterRow = true;
            this.grdFirmaSektor.OptionsView.ShowGroupPanel = false;
            this.grdFirmaSektor.OptionsView.ShowViewCaption = true;
            this.grdFirmaSektor.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSektor2, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grdFirmaSektor.ViewCaption = "Firma Faaliyet Alanları";
            // 
            // colSektor2
            // 
            this.colSektor2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colSektor2.AppearanceHeader.Options.UseFont = true;
            this.colSektor2.AppearanceHeader.Options.UseTextOptions = true;
            this.colSektor2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSektor2.Caption = "Faaliyet Alanı";
            this.colSektor2.FieldName = "Sektor";
            this.colSektor2.Name = "colSektor2";
            this.colSektor2.Visible = true;
            this.colSektor2.VisibleIndex = 0;
            // 
            // ulkelerTableAdapter
            // 
            this.ulkelerTableAdapter.ClearBeforeFill = true;
            // 
            // sehirlerTableAdapter
            // 
            this.sehirlerTableAdapter.ClearBeforeFill = true;
            // 
            // ilcelerTableAdapter
            // 
            this.ilcelerTableAdapter.ClearBeforeFill = true;
            // 
            // firmadakiPozisyonTableAdapter
            // 
            this.firmadakiPozisyonTableAdapter.ClearBeforeFill = true;
            // 
            // isletmeTuruTableAdapter
            // 
            this.isletmeTuruTableAdapter.ClearBeforeFill = true;
            // 
            // yillikCiroTableAdapter
            // 
            this.yillikCiroTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AltSektorlerTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.SektorlerTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = FirmaRehber.sektorlerDsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sektorlerTableAdapter
            // 
            this.sektorlerTableAdapter.ClearBeforeFill = true;
            // 
            // altSektorlerTableAdapter
            // 
            this.altSektorlerTableAdapter.ClearBeforeFill = true;
            // 
            // firmaSektorlerTableAdapter
            // 
            this.firmaSektorlerTableAdapter.ClearBeforeFill = true;
            // 
            // frmFirmaTnm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 842);
            this.Name = "frmFirmaTnm";
            this.Text = "Firma Kayıt";
            this.StateChanged += new System.EventHandler(this.frmFirmaTnm_StateChanged);
            this.Load += new System.EventHandler(this.frmFirmaTnm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).EndInit();
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAltSektor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sektorlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sektorlerDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSektor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altSektorlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaRehberDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePostaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semtTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilceLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ılcelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilcelerDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulkeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulkelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulkelerDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webSiteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vergiNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vergiDaireTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gsmTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faxTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaAdTextEdit.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calisanSayisiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yetkiliPozisyonLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmadakiPozisyonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yetkiliPozisyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etiketlerMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaHakkindaMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yillikCiroLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yillikCiroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yillikCiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isletmeTuruLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ısletmeTuruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isletmeTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kurulusYiliSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yetkiliTextEdit.Properties)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaSektorlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaSektorlerDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFirmaSektor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirmaRehberDataSet firmaRehberDataSet;
        private FirmaRehberDataSetTableAdapters.FirmalarTableAdapter firmalarTableAdapter;
        private FirmaRehberDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.PictureEdit logoPictureEdit;
        private DevExpress.XtraEditors.TextEdit semtTextEdit;
        private DevExpress.XtraEditors.LookUpEdit ilceLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit sehirLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit ulkeLookUpEdit;
        private DevExpress.XtraEditors.MemoEdit adresMemoEdit;
        private DevExpress.XtraEditors.TextEdit webSiteTextEdit;
        private DevExpress.XtraEditors.TextEdit vergiNoTextEdit;
        private DevExpress.XtraEditors.TextEdit vergiDaireTextEdit;
        private DevExpress.XtraEditors.TextEdit gsmTextEdit;
        private DevExpress.XtraEditors.TextEdit faxTextEdit;
        private DevExpress.XtraEditors.TextEdit telefonTextEdit;
        private DevExpress.XtraEditors.TextEdit firmaAdTextEdit;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.MemoEdit etiketlerMemoEdit;
        private DevExpress.XtraEditors.MemoEdit firmaHakkindaMemoEdit;
        private DevExpress.XtraEditors.LookUpEdit yillikCiroLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit isletmeTuruLookUpEdit;
        private DevExpress.XtraEditors.SpinEdit kurulusYiliSpinEdit;
        private DevExpress.XtraEditors.TextEdit yetkiliTextEdit;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.BindingSource firmalarBindingSource;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider ValidationProvider;
        private DevExpress.XtraEditors.TextEdit sehirTextEdit;
        private DevExpress.XtraEditors.LookUpEdit yetkiliPozisyonLookUpEdit;
        private ulkelerDs ulkelerDs;
        private System.Windows.Forms.BindingSource ulkelerBindingSource;
        private ulkelerDsTableAdapters.UlkelerTableAdapter ulkelerTableAdapter;
        private sehirlerDs sehirlerDs;
        private System.Windows.Forms.BindingSource sehirlerBindingSource;
        private sehirlerDsTableAdapters.SehirlerTableAdapter sehirlerTableAdapter;
        private ilcelerDs ilcelerDs;
        private System.Windows.Forms.BindingSource ılcelerBindingSource;
        private ilcelerDsTableAdapters.IlcelerTableAdapter ilcelerTableAdapter;
        private yetkiliPozisyon yetkiliPozisyon;
        private System.Windows.Forms.BindingSource firmadakiPozisyonBindingSource;
        private yetkiliPozisyonTableAdapters.FirmadakiPozisyonTableAdapter firmadakiPozisyonTableAdapter;
        private isletmeTuru isletmeTuru;
        private System.Windows.Forms.BindingSource ısletmeTuruBindingSource;
        private isletmeTuruTableAdapters.IsletmeTuruTableAdapter isletmeTuruTableAdapter;
        private yillikCiro yillikCiro;
        private System.Windows.Forms.BindingSource yillikCiroBindingSource;
        private yillikCiroTableAdapters.YillikCiroTableAdapter yillikCiroTableAdapter;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private sektorlerDsTableAdapters.TableAdapterManager tableAdapterManager1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView grdSektor;
        private sektorlerDs sektorlerDs;
        private System.Windows.Forms.BindingSource sektorlerBindingSource;
        private sektorlerDsTableAdapters.SektorlerTableAdapter sektorlerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSektor;
        private System.Windows.Forms.BindingSource altSektorlerBindingSource;
        private sektorlerDsTableAdapters.AltSektorlerTableAdapter altSektorlerTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView grdAltSektor;
        private DevExpress.XtraGrid.Columns.GridColumn colSektor1;
        private DevExpress.XtraEditors.SimpleButton btnSec;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView grdFirmaSektor;
        private FirmaSektorlerDs firmaSektorlerDs;
        private System.Windows.Forms.BindingSource firmaSektorlerBindingSource;
        private FirmaSektorlerDsTableAdapters.FirmaSektorlerTableAdapter firmaSektorlerTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colSektor2;
        private System.Windows.Forms.LinkLabel btnLogoTemizle;
        private System.Windows.Forms.LinkLabel btnLogoSec;
        private DevExpress.XtraEditors.TextEdit ePostaTextEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit calisanSayisiTextEdit;
    }
}