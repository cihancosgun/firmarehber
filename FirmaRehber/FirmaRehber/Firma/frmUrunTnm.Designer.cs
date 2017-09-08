namespace FirmaRehber.Firma
{
    partial class frmUrunTnm
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
            System.Windows.Forms.Label urunAdiLabel;
            System.Windows.Forms.Label aciklamaLabel;
            System.Windows.Forms.Label firmaLabel;
            System.Windows.Forms.Label tarihLabel;
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.urunlerDs = new FirmaRehber.UrunlerDs();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerTableAdapter = new FirmaRehber.UrunlerDsTableAdapters.UrunlerTableAdapter();
            this.tableAdapterManager = new FirmaRehber.UrunlerDsTableAdapters.TableAdapterManager();
            this.urunAdiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.aciklamaMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.ValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.firmaLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.vwFirmaAdListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwFirmaAdListDs = new FirmaRehber.vwFirmaAdListDs();
            this.tarihDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.vwFirmaAdListTableAdapter = new FirmaRehber.vwFirmaAdListDsTableAdapters.vwFirmaAdListTableAdapter();
            urunAdiLabel = new System.Windows.Forms.Label();
            aciklamaLabel = new System.Windows.Forms.Label();
            firmaLabel = new System.Windows.Forms.Label();
            tarihLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).BeginInit();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunAdiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aciklamaMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFirmaAdListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFirmaAdListDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarihDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarihDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Size = new System.Drawing.Size(296, 530);
            // 
            // Panel
            // 
            this.Panel.Controls.Add(tarihLabel);
            this.Panel.Controls.Add(this.tarihDateEdit);
            this.Panel.Controls.Add(firmaLabel);
            this.Panel.Controls.Add(this.firmaLookUpEdit);
            this.Panel.Controls.Add(aciklamaLabel);
            this.Panel.Controls.Add(this.aciklamaMemoEdit);
            this.Panel.Controls.Add(urunAdiLabel);
            this.Panel.Controls.Add(this.urunAdiTextEdit);
            this.Panel.Size = new System.Drawing.Size(405, 530);
            this.Panel.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 79);
            this.splitContainerControl1.Size = new System.Drawing.Size(706, 530);
            this.splitContainerControl1.SplitterPosition = 405;
            // 
            // urunAdiLabel
            // 
            urunAdiLabel.AutoSize = true;
            urunAdiLabel.Location = new System.Drawing.Point(45, 108);
            urunAdiLabel.Name = "urunAdiLabel";
            urunAdiLabel.Size = new System.Drawing.Size(52, 13);
            urunAdiLabel.TabIndex = 4;
            urunAdiLabel.Text = "Ürün Adı:";
            // 
            // aciklamaLabel
            // 
            aciklamaLabel.AutoSize = true;
            aciklamaLabel.Location = new System.Drawing.Point(29, 134);
            aciklamaLabel.Name = "aciklamaLabel";
            aciklamaLabel.Size = new System.Drawing.Size(68, 13);
            aciklamaLabel.TabIndex = 6;
            aciklamaLabel.Text = "Ürün Detayı:";
            // 
            // firmaLabel
            // 
            firmaLabel.AutoSize = true;
            firmaLabel.Location = new System.Drawing.Point(60, 56);
            firmaLabel.Name = "firmaLabel";
            firmaLabel.Size = new System.Drawing.Size(37, 13);
            firmaLabel.TabIndex = 7;
            firmaLabel.Text = "Firma:";
            // 
            // tarihLabel
            // 
            tarihLabel.AutoSize = true;
            tarihLabel.Location = new System.Drawing.Point(62, 82);
            tarihLabel.Name = "tarihLabel";
            tarihLabel.Size = new System.Drawing.Size(35, 13);
            tarihLabel.TabIndex = 8;
            tarihLabel.Text = "Tarih:";
            // 
            // urunlerDs
            // 
            this.urunlerDs.DataSetName = "UrunlerDs";
            this.urunlerDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.urunlerDs;
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = FirmaRehber.UrunlerDsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UrunlerTableAdapter = this.urunlerTableAdapter;
            // 
            // urunAdiTextEdit
            // 
            this.urunAdiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.urunlerBindingSource, "UrunAdi", true));
            this.urunAdiTextEdit.Location = new System.Drawing.Point(103, 105);
            this.urunAdiTextEdit.MenuManager = this.barManager1;
            this.urunAdiTextEdit.Name = "urunAdiTextEdit";
            this.urunAdiTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.urunAdiTextEdit.Properties.Appearance.Options.UseBackColor = true;
            this.urunAdiTextEdit.Size = new System.Drawing.Size(290, 20);
            this.urunAdiTextEdit.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Zorunlu.";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.ValidationProvider.SetValidationRule(this.urunAdiTextEdit, conditionValidationRule2);
            // 
            // aciklamaMemoEdit
            // 
            this.aciklamaMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.urunlerBindingSource, "UrunDetay", true));
            this.aciklamaMemoEdit.Location = new System.Drawing.Point(103, 131);
            this.aciklamaMemoEdit.MenuManager = this.barManager1;
            this.aciklamaMemoEdit.Name = "aciklamaMemoEdit";
            this.aciklamaMemoEdit.Size = new System.Drawing.Size(290, 178);
            this.aciklamaMemoEdit.TabIndex = 3;
            // 
            // firmaLookUpEdit
            // 
            this.firmaLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.urunlerBindingSource, "Firma", true));
            this.firmaLookUpEdit.Location = new System.Drawing.Point(103, 53);
            this.firmaLookUpEdit.MenuManager = this.barManager1;
            this.firmaLookUpEdit.Name = "firmaLookUpEdit";
            this.firmaLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.firmaLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FirmaAd", "Firma Ad", 52, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.firmaLookUpEdit.Properties.DataSource = this.vwFirmaAdListBindingSource;
            this.firmaLookUpEdit.Properties.DisplayMember = "FirmaAd";
            this.firmaLookUpEdit.Properties.ValueMember = "FirmaAd";
            this.firmaLookUpEdit.Size = new System.Drawing.Size(290, 20);
            this.firmaLookUpEdit.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Zorunlu.";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.ValidationProvider.SetValidationRule(this.firmaLookUpEdit, conditionValidationRule1);
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
            // tarihDateEdit
            // 
            this.tarihDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.urunlerBindingSource, "Tarih", true));
            this.tarihDateEdit.EditValue = null;
            this.tarihDateEdit.Location = new System.Drawing.Point(103, 79);
            this.tarihDateEdit.MenuManager = this.barManager1;
            this.tarihDateEdit.Name = "tarihDateEdit";
            this.tarihDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tarihDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.tarihDateEdit.Size = new System.Drawing.Size(100, 20);
            this.tarihDateEdit.TabIndex = 1;
            // 
            // vwFirmaAdListTableAdapter
            // 
            this.vwFirmaAdListTableAdapter.ClearBeforeFill = true;
            // 
            // frmUrunTnm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(706, 633);
            this.Name = "frmUrunTnm";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.frmUrunTnm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunAdiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aciklamaMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFirmaAdListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFirmaAdListDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarihDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarihDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UrunlerDs urunlerDs;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private UrunlerDsTableAdapters.UrunlerTableAdapter urunlerTableAdapter;
        private UrunlerDsTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.MemoEdit aciklamaMemoEdit;
        private DevExpress.XtraEditors.TextEdit urunAdiTextEdit;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider ValidationProvider;
        private DevExpress.XtraEditors.DateEdit tarihDateEdit;
        private DevExpress.XtraEditors.LookUpEdit firmaLookUpEdit;
        private vwFirmaAdListDs vwFirmaAdListDs;
        private System.Windows.Forms.BindingSource vwFirmaAdListBindingSource;
        private vwFirmaAdListDsTableAdapters.vwFirmaAdListTableAdapter vwFirmaAdListTableAdapter;
    }
}
