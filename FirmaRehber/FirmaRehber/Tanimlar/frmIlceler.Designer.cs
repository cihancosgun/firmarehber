namespace FirmaRehber.Tanimlar
{
    partial class frmIlceler
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
            System.Windows.Forms.Label ustIdLabel;
            System.Windows.Forms.Label ilceLabel;
            this.ilcelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ustIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ilceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sehirlerDs = new FirmaRehber.sehirlerDs();
            this.sehirlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sehirlerTableAdapter = new FirmaRehber.sehirlerDsTableAdapters.SehirlerTableAdapter();
            ustIdLabel = new System.Windows.Forms.Label();
            ilceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).BeginInit();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ilcelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Red;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            // 
            // Panel
            // 
            this.Panel.Controls.Add(ilceLabel);
            this.Panel.Controls.Add(this.ilceTextEdit);
            this.Panel.Controls.Add(ustIdLabel);
            this.Panel.Controls.Add(this.ustIdLookUpEdit);
            // 
            // ustIdLabel
            // 
            ustIdLabel.AutoSize = true;
            ustIdLabel.Location = new System.Drawing.Point(23, 30);
            ustIdLabel.Name = "ustIdLabel";
            ustIdLabel.Size = new System.Drawing.Size(35, 13);
            ustIdLabel.TabIndex = 0;
            ustIdLabel.Text = "Şehir:";
            // 
            // ilceLabel
            // 
            ilceLabel.AutoSize = true;
            ilceLabel.Location = new System.Drawing.Point(30, 56);
            ilceLabel.Name = "ilceLabel";
            ilceLabel.Size = new System.Drawing.Size(28, 13);
            ilceLabel.TabIndex = 2;
            ilceLabel.Text = "İlçe:";
            // 
            // ustIdLookUpEdit
            // 
            this.ustIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ilcelerBindingSource, "UstId", true));
            this.ustIdLookUpEdit.Location = new System.Drawing.Point(64, 27);
            this.ustIdLookUpEdit.MenuManager = this.barManager1;
            this.ustIdLookUpEdit.Name = "ustIdLookUpEdit";
            this.ustIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ustIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sehir", "Sehir", 34, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ustIdLookUpEdit.Properties.DataSource = this.sehirlerBindingSource;
            this.ustIdLookUpEdit.Properties.DisplayMember = "Sehir";
            this.ustIdLookUpEdit.Properties.ValueMember = "Id";
            this.ustIdLookUpEdit.Size = new System.Drawing.Size(233, 20);
            this.ustIdLookUpEdit.TabIndex = 1;
            // 
            // ilceTextEdit
            // 
            this.ilceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ilcelerBindingSource, "Ilce", true));
            this.ilceTextEdit.Location = new System.Drawing.Point(64, 53);
            this.ilceTextEdit.MenuManager = this.barManager1;
            this.ilceTextEdit.Name = "ilceTextEdit";
            this.ilceTextEdit.Size = new System.Drawing.Size(233, 20);
            this.ilceTextEdit.TabIndex = 3;
            // 
            // sehirlerDs
            // 
            this.sehirlerDs.DataSetName = "sehirlerDs";
            this.sehirlerDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sehirlerBindingSource
            // 
            this.sehirlerBindingSource.DataMember = "Sehirler";
            this.sehirlerBindingSource.DataSource = this.sehirlerDs;
            // 
            // sehirlerTableAdapter
            // 
            this.sehirlerTableAdapter.ClearBeforeFill = true;
            // 
            // frmIlceler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(595, 541);
            this.Name = "frmIlceler";
            this.Text = "İlçeler";
            this.Load += new System.EventHandler(this.frmIlceler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ilcelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ustIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit ustIdLookUpEdit;
        private DevExpress.XtraEditors.TextEdit ilceTextEdit;
        public System.Windows.Forms.BindingSource ilcelerBindingSource;
        private sehirlerDs sehirlerDs;
        private System.Windows.Forms.BindingSource sehirlerBindingSource;
        private sehirlerDsTableAdapters.SehirlerTableAdapter sehirlerTableAdapter;
    }
}
