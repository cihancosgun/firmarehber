namespace FirmaRehber.Firma
{
    partial class frmFirmaAlimlar
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
            System.Windows.Forms.Label aciklamaLabel;
            System.Windows.Forms.Label ilanTarihLabel;
            System.Windows.Forms.Label firmaRefLabel;
            System.Windows.Forms.Label ilanBaslikLabel;
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.firmaAlimlarDs = new FirmaRehber.FirmaAlimlarDs();
            this.firmaAlimlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmaAlimlarTableAdapter = new FirmaRehber.FirmaAlimlarDsTableAdapters.FirmaAlimlarTableAdapter();
            this.tableAdapterManager = new FirmaRehber.FirmaAlimlarDsTableAdapters.TableAdapterManager();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.ilanBaslikMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.aciklamaMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.firmaRefLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.vwFirmaAdListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwFirmaAdListDs = new FirmaRehber.vwFirmaAdListDs();
            this.ilanTarihDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.firmaAlimlarKalemGridControl = new DevExpress.XtraGrid.GridControl();
            this.firmaAlimlarKalemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUrunRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerDs = new FirmaRehber.UrunlerDs();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.firmaAlimlarKalemTableAdapter = new FirmaRehber.FirmaAlimlarDsTableAdapters.FirmaAlimlarKalemTableAdapter();
            this.urunlerTableAdapter = new FirmaRehber.UrunlerDsTableAdapters.UrunlerTableAdapter();
            this.vwFirmaAdListTableAdapter = new FirmaRehber.vwFirmaAdListDsTableAdapters.vwFirmaAdListTableAdapter();
            this.ValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            aciklamaLabel = new System.Windows.Forms.Label();
            ilanTarihLabel = new System.Windows.Forms.Label();
            firmaRefLabel = new System.Windows.Forms.Label();
            ilanBaslikLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).BeginInit();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmaAlimlarDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaAlimlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ilanBaslikMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aciklamaMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaRefLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFirmaAdListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFirmaAdListDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilanTarihDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilanTarihDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmaAlimlarKalemGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaAlimlarKalemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Size = new System.Drawing.Size(378, 555);
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.splitContainerControl2);
            this.Panel.Size = new System.Drawing.Size(371, 555);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 79);
            this.splitContainerControl1.Size = new System.Drawing.Size(754, 555);
            this.splitContainerControl1.SplitterPosition = 371;
            // 
            // aciklamaLabel
            // 
            aciklamaLabel.AutoSize = true;
            aciklamaLabel.Location = new System.Drawing.Point(12, 111);
            aciklamaLabel.Name = "aciklamaLabel";
            aciklamaLabel.Size = new System.Drawing.Size(52, 13);
            aciklamaLabel.TabIndex = 14;
            aciklamaLabel.Text = "Aciklama:";
            // 
            // ilanTarihLabel
            // 
            ilanTarihLabel.AutoSize = true;
            ilanTarihLabel.Location = new System.Drawing.Point(8, 85);
            ilanTarihLabel.Name = "ilanTarihLabel";
            ilanTarihLabel.Size = new System.Drawing.Size(56, 13);
            ilanTarihLabel.TabIndex = 12;
            ilanTarihLabel.Text = "Ilan Tarih:";
            // 
            // firmaRefLabel
            // 
            firmaRefLabel.AutoSize = true;
            firmaRefLabel.Location = new System.Drawing.Point(24, 19);
            firmaRefLabel.Name = "firmaRefLabel";
            firmaRefLabel.Size = new System.Drawing.Size(37, 13);
            firmaRefLabel.TabIndex = 8;
            firmaRefLabel.Text = "Firma:";
            // 
            // ilanBaslikLabel
            // 
            ilanBaslikLabel.AutoSize = true;
            ilanBaslikLabel.Location = new System.Drawing.Point(6, 45);
            ilanBaslikLabel.Name = "ilanBaslikLabel";
            ilanBaslikLabel.Size = new System.Drawing.Size(58, 13);
            ilanBaslikLabel.TabIndex = 10;
            ilanBaslikLabel.Text = "Ilan Baslik:";
            // 
            // firmaAlimlarDs
            // 
            this.firmaAlimlarDs.DataSetName = "FirmaAlimlarDs";
            this.firmaAlimlarDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // firmaAlimlarBindingSource
            // 
            this.firmaAlimlarBindingSource.DataMember = "FirmaAlimlar";
            this.firmaAlimlarBindingSource.DataSource = this.firmaAlimlarDs;
            // 
            // firmaAlimlarTableAdapter
            // 
            this.firmaAlimlarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FirmaAlimlarKalemTableAdapter = null;
            this.tableAdapterManager.FirmaAlimlarTableAdapter = this.firmaAlimlarTableAdapter;
            this.tableAdapterManager.UpdateOrder = FirmaRehber.FirmaAlimlarDsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(aciklamaLabel);
            this.splitContainerControl2.Panel1.Controls.Add(this.ilanBaslikMemoEdit);
            this.splitContainerControl2.Panel1.Controls.Add(this.aciklamaMemoEdit);
            this.splitContainerControl2.Panel1.Controls.Add(this.firmaRefLookUpEdit);
            this.splitContainerControl2.Panel1.Controls.Add(ilanTarihLabel);
            this.splitContainerControl2.Panel1.Controls.Add(firmaRefLabel);
            this.splitContainerControl2.Panel1.Controls.Add(this.ilanTarihDateEdit);
            this.splitContainerControl2.Panel1.Controls.Add(ilanBaslikLabel);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(367, 551);
            this.splitContainerControl2.SplitterPosition = 189;
            this.splitContainerControl2.TabIndex = 8;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // ilanBaslikMemoEdit
            // 
            this.ilanBaslikMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmaAlimlarBindingSource, "IlanBaslik", true));
            this.ilanBaslikMemoEdit.Location = new System.Drawing.Point(70, 42);
            this.ilanBaslikMemoEdit.MenuManager = this.barManager1;
            this.ilanBaslikMemoEdit.Name = "ilanBaslikMemoEdit";
            this.ilanBaslikMemoEdit.Size = new System.Drawing.Size(259, 34);
            this.ilanBaslikMemoEdit.TabIndex = 11;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Zorunlu.";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.ValidationProvider.SetValidationRule(this.ilanBaslikMemoEdit, conditionValidationRule3);
            // 
            // aciklamaMemoEdit
            // 
            this.aciklamaMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmaAlimlarBindingSource, "Aciklama", true));
            this.aciklamaMemoEdit.Location = new System.Drawing.Point(70, 108);
            this.aciklamaMemoEdit.MenuManager = this.barManager1;
            this.aciklamaMemoEdit.Name = "aciklamaMemoEdit";
            this.aciklamaMemoEdit.Size = new System.Drawing.Size(259, 63);
            this.aciklamaMemoEdit.TabIndex = 15;
            // 
            // firmaRefLookUpEdit
            // 
            this.firmaRefLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmaAlimlarBindingSource, "FirmaRef", true));
            this.firmaRefLookUpEdit.Location = new System.Drawing.Point(70, 16);
            this.firmaRefLookUpEdit.MenuManager = this.barManager1;
            this.firmaRefLookUpEdit.Name = "firmaRefLookUpEdit";
            this.firmaRefLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.firmaRefLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FirmaAd", "Firma", 52, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.firmaRefLookUpEdit.Properties.DataSource = this.vwFirmaAdListBindingSource;
            this.firmaRefLookUpEdit.Properties.DisplayMember = "FirmaAd";
            this.firmaRefLookUpEdit.Properties.ValueMember = "Id";
            this.firmaRefLookUpEdit.Size = new System.Drawing.Size(259, 20);
            this.firmaRefLookUpEdit.TabIndex = 9;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Zorunlu.";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.ValidationProvider.SetValidationRule(this.firmaRefLookUpEdit, conditionValidationRule1);
            // 
            // vwFirmaAdListBindingSource
            // 
            this.vwFirmaAdListBindingSource.DataMember = "vwFirmaAdList";
            this.vwFirmaAdListBindingSource.DataSource = this.vwFirmaAdListDs;
            // 
            // vwFirmaAdListDs
            // 
            this.vwFirmaAdListDs.DataSetName = "vwFirmaAdListDs";
            this.vwFirmaAdListDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ilanTarihDateEdit
            // 
            this.ilanTarihDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmaAlimlarBindingSource, "IlanTarih", true));
            this.ilanTarihDateEdit.EditValue = null;
            this.ilanTarihDateEdit.Location = new System.Drawing.Point(70, 82);
            this.ilanTarihDateEdit.MenuManager = this.barManager1;
            this.ilanTarihDateEdit.Name = "ilanTarihDateEdit";
            this.ilanTarihDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ilanTarihDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ilanTarihDateEdit.Size = new System.Drawing.Size(100, 20);
            this.ilanTarihDateEdit.TabIndex = 13;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.firmaAlimlarKalemGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(367, 357);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Alınacak Ürünler";
            // 
            // firmaAlimlarKalemGridControl
            // 
            this.firmaAlimlarKalemGridControl.DataSource = this.firmaAlimlarKalemBindingSource;
            this.firmaAlimlarKalemGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firmaAlimlarKalemGridControl.Location = new System.Drawing.Point(2, 24);
            this.firmaAlimlarKalemGridControl.MainView = this.gridView1;
            this.firmaAlimlarKalemGridControl.MenuManager = this.barManager1;
            this.firmaAlimlarKalemGridControl.Name = "firmaAlimlarKalemGridControl";
            this.firmaAlimlarKalemGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemLookUpEdit1});
            this.firmaAlimlarKalemGridControl.Size = new System.Drawing.Size(363, 331);
            this.firmaAlimlarKalemGridControl.TabIndex = 0;
            this.firmaAlimlarKalemGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // firmaAlimlarKalemBindingSource
            // 
            this.firmaAlimlarKalemBindingSource.DataMember = "FirmaAlimlar_FirmaAlimlarKalem";
            this.firmaAlimlarKalemBindingSource.DataSource = this.firmaAlimlarBindingSource;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUrunRef,
            this.colMiktar});
            this.gridView1.GridControl = this.firmaAlimlarKalemGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colUrunRef
            // 
            this.colUrunRef.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colUrunRef.AppearanceHeader.Options.UseFont = true;
            this.colUrunRef.AppearanceHeader.Options.UseTextOptions = true;
            this.colUrunRef.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colUrunRef.Caption = "Alınacak Ürün";
            this.colUrunRef.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colUrunRef.FieldName = "Urun";
            this.colUrunRef.Name = "colUrunRef";
            this.colUrunRef.Visible = true;
            this.colUrunRef.VisibleIndex = 0;
            this.colUrunRef.Width = 230;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UrunAdi", "Urun Adi", 51, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Firma", "Firma", 36, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tarih", "Tarih", 34, DevExpress.Utils.FormatType.DateTime, "dd.MM.yyyy", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UrunDetay", "Urun Detay", 65, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit1.DataSource = this.urunlerBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "UrunAdi";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "UrunAdi";
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.urunlerDs;
            // 
            // urunlerDs
            // 
            this.urunlerDs.DataSetName = "UrunlerDs";
            this.urunlerDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colMiktar
            // 
            this.colMiktar.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.colMiktar.AppearanceHeader.Options.UseFont = true;
            this.colMiktar.AppearanceHeader.Options.UseTextOptions = true;
            this.colMiktar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMiktar.Caption = "Alınacak Miktar";
            this.colMiktar.ColumnEdit = this.repositoryItemTextEdit1;
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 1;
            this.colMiktar.Width = 114;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Mask.EditMask = "n";
            this.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // firmaAlimlarKalemTableAdapter
            // 
            this.firmaAlimlarKalemTableAdapter.ClearBeforeFill = true;
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // vwFirmaAdListTableAdapter
            // 
            this.vwFirmaAdListTableAdapter.ClearBeforeFill = true;
            // 
            // frmFirmaAlimlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(754, 658);
            this.Name = "frmFirmaAlimlar";
            this.Text = "Firma Alımlar";
            this.Load += new System.EventHandler(this.frmFirmaAlimlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).EndInit();
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.firmaAlimlarDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaAlimlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ilanBaslikMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aciklamaMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaRefLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFirmaAdListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFirmaAdListDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilanTarihDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilanTarihDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.firmaAlimlarKalemGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaAlimlarKalemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FirmaAlimlarDs firmaAlimlarDs;
        private System.Windows.Forms.BindingSource firmaAlimlarBindingSource;
        private FirmaAlimlarDsTableAdapters.FirmaAlimlarTableAdapter firmaAlimlarTableAdapter;
        private FirmaAlimlarDsTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.MemoEdit ilanBaslikMemoEdit;
        private DevExpress.XtraEditors.MemoEdit aciklamaMemoEdit;
        private DevExpress.XtraEditors.LookUpEdit firmaRefLookUpEdit;
        private DevExpress.XtraEditors.DateEdit ilanTarihDateEdit;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingSource firmaAlimlarKalemBindingSource;
        private FirmaAlimlarDsTableAdapters.FirmaAlimlarKalemTableAdapter firmaAlimlarKalemTableAdapter;
        private DevExpress.XtraGrid.GridControl firmaAlimlarKalemGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunRef;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private UrunlerDs urunlerDs;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private UrunlerDsTableAdapters.UrunlerTableAdapter urunlerTableAdapter;
        private vwFirmaAdListDs vwFirmaAdListDs;
        private System.Windows.Forms.BindingSource vwFirmaAdListBindingSource;
        private vwFirmaAdListDsTableAdapters.vwFirmaAdListTableAdapter vwFirmaAdListTableAdapter;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider ValidationProvider;
    }
}
