namespace FirmaRehber.Tanimlar
{
    partial class frmSehirler
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
            System.Windows.Forms.Label sehirLabel;
            this.sehirlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sehirTextEdit = new DevExpress.XtraEditors.TextEdit();
            sehirLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).BeginInit();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirTextEdit.Properties)).BeginInit();
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
            this.Panel.Controls.Add(sehirLabel);
            this.Panel.Controls.Add(this.sehirTextEdit);
            // 
            // sehirLabel
            // 
            sehirLabel.AutoSize = true;
            sehirLabel.Location = new System.Drawing.Point(23, 22);
            sehirLabel.Name = "sehirLabel";
            sehirLabel.Size = new System.Drawing.Size(35, 13);
            sehirLabel.TabIndex = 0;
            sehirLabel.Text = "Sehir:";
            // 
            // sehirTextEdit
            // 
            this.sehirTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sehirlerBindingSource, "Sehir", true));
            this.sehirTextEdit.Location = new System.Drawing.Point(64, 19);
            this.sehirTextEdit.MenuManager = this.barManager1;
            this.sehirTextEdit.Name = "sehirTextEdit";
            this.sehirTextEdit.Size = new System.Drawing.Size(194, 20);
            this.sehirTextEdit.TabIndex = 1;
            // 
            // frmSehirler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(595, 541);
            this.Name = "frmSehirler";
            this.Text = "Şehirler";
            this.Load += new System.EventHandler(this.frmSehirler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sehirlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit sehirTextEdit;
        public System.Windows.Forms.BindingSource sehirlerBindingSource;
    }
}
