namespace FirmaRehber.Tanimlar
{
    partial class frmYetkiliPozisyonTnm
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
            System.Windows.Forms.Label firmadakiPozisyonLabel;
            this.firmadakiPozisyonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmadakiPozisyonTextEdit = new DevExpress.XtraEditors.TextEdit();
            firmadakiPozisyonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).BeginInit();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmadakiPozisyonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmadakiPozisyonTextEdit.Properties)).BeginInit();
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
            this.Panel.Controls.Add(firmadakiPozisyonLabel);
            this.Panel.Controls.Add(this.firmadakiPozisyonTextEdit);
            // 
            // firmadakiPozisyonLabel
            // 
            firmadakiPozisyonLabel.AutoSize = true;
            firmadakiPozisyonLabel.Location = new System.Drawing.Point(13, 30);
            firmadakiPozisyonLabel.Name = "firmadakiPozisyonLabel";
            firmadakiPozisyonLabel.Size = new System.Drawing.Size(101, 13);
            firmadakiPozisyonLabel.TabIndex = 0;
            firmadakiPozisyonLabel.Text = "Firmadaki Pozisyon:";
            // 
            // firmadakiPozisyonTextEdit
            // 
            this.firmadakiPozisyonTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.firmadakiPozisyonBindingSource, "FirmadakiPozisyon", true));
            this.firmadakiPozisyonTextEdit.Location = new System.Drawing.Point(120, 27);
            this.firmadakiPozisyonTextEdit.MenuManager = this.barManager1;
            this.firmadakiPozisyonTextEdit.Name = "firmadakiPozisyonTextEdit";
            this.firmadakiPozisyonTextEdit.Size = new System.Drawing.Size(155, 20);
            this.firmadakiPozisyonTextEdit.TabIndex = 1;
            // 
            // frmYetkiliPozisyonTnm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(595, 541);
            this.Name = "frmYetkiliPozisyonTnm";
            this.Text = "Yetkili Pozisyonları";
            this.Load += new System.EventHandler(this.frmYetkiliPozisyonTnm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.firmadakiPozisyonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmadakiPozisyonTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit firmadakiPozisyonTextEdit;
        public System.Windows.Forms.BindingSource firmadakiPozisyonBindingSource;
    }
}
