namespace FirmaRehber.Tanimlar
{
    partial class frmUlkeler
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
            System.Windows.Forms.Label kODULabel;
            System.Windows.Forms.Label aDILabel;
            this.ulkelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kODUTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.aDITextEdit = new DevExpress.XtraEditors.TextEdit();
            kODULabel = new System.Windows.Forms.Label();
            aDILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).BeginInit();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ulkelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kODUTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDITextEdit.Properties)).BeginInit();
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
            this.Panel.Controls.Add(aDILabel);
            this.Panel.Controls.Add(this.aDITextEdit);
            this.Panel.Controls.Add(kODULabel);
            this.Panel.Controls.Add(this.kODUTextEdit);
            // 
            // kODULabel
            // 
            kODULabel.AutoSize = true;
            kODULabel.Location = new System.Drawing.Point(27, 30);
            kODULabel.Name = "kODULabel";
            kODULabel.Size = new System.Drawing.Size(39, 13);
            kODULabel.TabIndex = 0;
            kODULabel.Text = "KODU:";
            // 
            // aDILabel
            // 
            aDILabel.AutoSize = true;
            aDILabel.Location = new System.Drawing.Point(37, 56);
            aDILabel.Name = "aDILabel";
            aDILabel.Size = new System.Drawing.Size(29, 13);
            aDILabel.TabIndex = 2;
            aDILabel.Text = "ADI:";
            // 
            // kODUTextEdit
            // 
            this.kODUTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ulkelerBindingSource, "KODU", true));
            this.kODUTextEdit.Location = new System.Drawing.Point(72, 27);
            this.kODUTextEdit.MenuManager = this.barManager1;
            this.kODUTextEdit.Name = "kODUTextEdit";
            this.kODUTextEdit.Size = new System.Drawing.Size(100, 20);
            this.kODUTextEdit.TabIndex = 1;
            // 
            // aDITextEdit
            // 
            this.aDITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ulkelerBindingSource, "ADI", true));
            this.aDITextEdit.Location = new System.Drawing.Point(72, 53);
            this.aDITextEdit.MenuManager = this.barManager1;
            this.aDITextEdit.Name = "aDITextEdit";
            this.aDITextEdit.Size = new System.Drawing.Size(205, 20);
            this.aDITextEdit.TabIndex = 3;
            // 
            // frmUlkeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(595, 541);
            this.Name = "frmUlkeler";
            this.Text = "Ülkeler";
            this.Load += new System.EventHandler(this.frmUlkeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ulkelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kODUTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDITextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit aDITextEdit;
        private DevExpress.XtraEditors.TextEdit kODUTextEdit;
        public System.Windows.Forms.BindingSource ulkelerBindingSource;
    }
}
