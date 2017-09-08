namespace FirmaRehber.Tanimlar
{
    partial class frmYillikCiroTnm
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
            System.Windows.Forms.Label yillikCiroLabel;
            this.yillikCiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yillikCiroTextEdit = new DevExpress.XtraEditors.TextEdit();
            yillikCiroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).BeginInit();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yillikCiroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yillikCiroTextEdit.Properties)).BeginInit();
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
            this.Panel.Controls.Add(yillikCiroLabel);
            this.Panel.Controls.Add(this.yillikCiroTextEdit);
            // 
            // yillikCiroLabel
            // 
            yillikCiroLabel.AutoSize = true;
            yillikCiroLabel.Location = new System.Drawing.Point(25, 47);
            yillikCiroLabel.Name = "yillikCiroLabel";
            yillikCiroLabel.Size = new System.Drawing.Size(52, 13);
            yillikCiroLabel.TabIndex = 0;
            yillikCiroLabel.Text = "Yillik Ciro:";
            // 
            // yillikCiroTextEdit
            // 
            this.yillikCiroTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.yillikCiroBindingSource, "YillikCiro", true));
            this.yillikCiroTextEdit.Location = new System.Drawing.Point(83, 44);
            this.yillikCiroTextEdit.MenuManager = this.barManager1;
            this.yillikCiroTextEdit.Name = "yillikCiroTextEdit";
            this.yillikCiroTextEdit.Size = new System.Drawing.Size(191, 20);
            this.yillikCiroTextEdit.TabIndex = 1;
            // 
            // frmYillikCiroTnm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(595, 541);
            this.Name = "frmYillikCiroTnm";
            this.Text = "Yıllık Ciro";
            this.Load += new System.EventHandler(this.frmYillikCiroTnm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Panel)).EndInit();
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yillikCiroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yillikCiroTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit yillikCiroTextEdit;
        public System.Windows.Forms.BindingSource yillikCiroBindingSource;
    }
}
