using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FirmaRehber.BaseForm
{
    public partial class BaseForm : DevExpress.XtraEditors.XtraForm
    {

        private bool _Editing = false;
        public bool Editing
        {
            get { return _Editing; }
            set
            {
                _Editing = value;
                Panel.Enabled = value;
                beDurum.Caption = "Durum : " + (value ? "Düzenleme" : "Gezinme");
                if (StateChanged != null)
                    StateChanged(null, null);

                btnNew.Enabled = !value;
                btnSave.Enabled = value;
                btnCancel.Enabled = value;
                btnClose.Enabled = !value;
                btnDelete.Enabled = value;
                Grid.Enabled = !value;
            }
        }

        public BaseForm()
        {
            InitializeComponent();
            beDurum.Caption = "Durum : Düzenleme";
            Editing = true;
        }

        #region Properties
        bool _Yeni = true;
        [Category("_PF")]
        public bool Yeni
        {
            get { return _Yeni; }
            set { _Yeni = value; btnNew.Visibility = value ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never; }
        }
        bool _Kaydet = true;
        [Category("_PF")]
        public bool Kaydet
        {
            get { return _Kaydet; }
            set { _Kaydet = value; btnSave.Visibility = value ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never; }
        }
        bool _Sil = true;
        [Category("_PF")]
        public bool Sil
        {
            get { return _Sil; }
            set { _Sil = value; btnDelete.Visibility = value ? DevExpress.XtraBars.BarItemVisibility.Always : DevExpress.XtraBars.BarItemVisibility.Never; }
        }
        #endregion

        DataTable GetList(string Sql)
        {
            DataTable dtNew = new DataTable();
            using (OleDbConnection con = new OleDbConnection(Properties.Settings.Default.DataConnectionString1))
            {
                OleDbDataAdapter da = new OleDbDataAdapter(Sql, con);
                da.Fill(dtNew);
            }
            return dtNew;
        }

        #region Events
        public virtual void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            beDurum.Caption = "Durum : Yeni Kayıt";
            Editing = true;
        }

        public virtual void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            beDurum.Caption = "Durum : Kaydet";
            Editing = false;
        }

        public virtual void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            beDurum.Caption = "Durum : Sil";
            Editing = false;
        }

        public virtual void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        public virtual void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Editing = false;
        }

        public event EventHandler StateChanged;
        #endregion

        private void BaseForm_Load(object sender, EventArgs e)
        {
            MemoEditControl(Panel);
        }

        void MemoEditControl(Control sender)
        {
            try
            {
                foreach (Control item in sender.Controls)
                {
                    if (item.GetType() == typeof(DevExpress.XtraEditors.MemoEdit))
                    {
                        (item as DevExpress.XtraEditors.MemoEdit).Properties.MaxLength = 250;
                    }
                    MemoEditControl(item);
                }
            }
            catch { }
        }

        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            Editing = true;
        }

        private void barLargeButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sv = new SaveFileDialog())
                {
                    sv.Filter = "Excell|*.xls";
                    sv.FileName = "Liste.xls";
                    if (sv.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(sv.FileName))
                    {
                        Grid.ExportToXls(sv.FileName, new DevExpress.XtraPrinting.XlsExportOptions(DevExpress.XtraPrinting.TextExportMode.Text));
                        MessageBox.Show("Excell çıkarma başarılı.", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (System.IO.File.Exists(sv.FileName))
                        {
                            System.Diagnostics.Process.Start(sv.FileName);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
