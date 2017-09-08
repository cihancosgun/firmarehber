using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace FirmaRehber.Tanimlar
{
    public partial class frmYillikCiroTnm : FirmaRehber.BaseForm.BaseForm
    {
        public yillikCiro yillikCiro = null;
        public yillikCiroTableAdapters.YillikCiroTableAdapter yillikCiroTableAdapter = null;

        public frmYillikCiroTnm()
        {
            InitializeComponent();
        }

        private void frmYillikCiroTnm_Load(object sender, EventArgs e)
        {            
            this.yillikCiroTableAdapter.Fill(this.yillikCiro.YillikCiro);
            BN.BindingSource = yillikCiroBindingSource;
            Grid.DataSource = yillikCiroBindingSource;
            GridView.Columns["Id"].Visible = false;
            btnNew.PerformClick();
            GridView.OptionsSelection.MultiSelect = true;
            GridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
        }

        #region OVerride
        public override void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnNew_ItemClick(sender, e);
            yillikCiroBindingSource.CancelEdit();
            yillikCiroBindingSource.AddNew();
        }

        public override void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnSave_ItemClick(sender, e);
            yillikCiroBindingSource.EndEdit();
            yillikCiroTableAdapter.Update(yillikCiro);
        }

        public override void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnCancel_ItemClick(sender, e);
            yillikCiroBindingSource.CancelEdit();
        }

        public override void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnDelete_ItemClick(sender, e);
            if (GridView.GetSelectedRows().Length > 0)
            {
                if (XtraMessageBox.Show("Kaydı silmek istediğinize emin misiniz ?", "Sil", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    yillikCiroBindingSource.CancelEdit();
                    int[] SilId = new int[GridView.GetSelectedRows().Length];
                    for (int i = 0; i < GridView.GetSelectedRows().Length; i++)
                        if (GridView.GetDataRow(GridView.GetSelectedRows()[i]) != null)
                            SilId[i] = int.Parse(GridView.GetDataRow(GridView.GetSelectedRows()[i])["Id"].ToString());

                    for (int z = 0; z < SilId.Length; z++)
                    {
                        yillikCiroBindingSource.Filter = "Id = " + SilId[z].ToString();
                        try { yillikCiroBindingSource.RemoveCurrent(); }
                        catch { }
                    }
                    try
                    {
                        yillikCiroTableAdapter.Update(yillikCiro);
                    }
                    catch { }

                }
                yillikCiroBindingSource.Filter = "";
            }
        }

        public override void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            yillikCiroBindingSource.CancelEdit();
            base.btnClose_ItemClick(sender, e);
        }
        #endregion
    }
}
