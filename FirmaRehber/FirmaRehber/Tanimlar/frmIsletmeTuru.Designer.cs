namespace FirmaRehber.Tanimlar
{
    partial class frmIsletmeTuru
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
            System.Windows.Forms.Label isletmeTuruLabel;
            this.isletmeTuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isletmeTuruTextEdit = new DevExpress.XtraEditors.TextEdit();
            isletmeTuruLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).BeginInit();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isletmeTuruBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isletmeTuruTextEdit.Properties)).BeginInit();
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
            this.Panel.Controls.Add(isletmeTuruLabel);
            this.Panel.Controls.Add(this.isletmeTuruTextEdit);
            // 
            // isletmeTuruLabel
            // 
            isletmeTuruLabel.AutoSize = true;
            isletmeTuruLabel.Location = new System.Drawing.Point(19, 22);
            isletmeTuruLabel.Name = "isletmeTuruLabel";
            isletmeTuruLabel.Size = new System.Drawing.Size(71, 13);
            isletmeTuruLabel.TabIndex = 0;
            isletmeTuruLabel.Text = "Isletme Turu:";
            // 
            // isletmeTuruTextEdit
            // 
            this.isletmeTuruTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.isletmeTuruBindingSource, "IsletmeTuru", true));
            this.isletmeTuruTextEdit.Location = new System.Drawing.Point(96, 19);
            this.isletmeTuruTextEdit.MenuManager = this.barManager1;
            this.isletmeTuruTextEdit.Name = "isletmeTuruTextEdit";
            this.isletmeTuruTextEdit.Size = new System.Drawing.Size(177, 20);
            this.isletmeTuruTextEdit.TabIndex = 1;
            // 
            // frmIsletmeTuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(595, 541);
            this.Name = "frmIsletmeTuru";
            this.Text = "İşletme Türü";
            this.Load += new System.EventHandler(this.frmIsletmeTuru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.isletmeTuruBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isletmeTuruTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit isletmeTuruTextEdit;
        public System.Windows.Forms.BindingSource isletmeTuruBindingSource;
    }
}
