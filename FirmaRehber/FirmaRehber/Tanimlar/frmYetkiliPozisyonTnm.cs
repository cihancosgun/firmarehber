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
    public partial class frmYetkiliPozisyonTnm : FirmaRehber.BaseForm.BaseForm
    {
        public yetkiliPozisyon yetkiliPozisyon = null;
        public yetkiliPozisyonTableAdapters.FirmadakiPozisyonTableAdapter firmadakiPozisyonTableAdapter = null;
        public frmYetkiliPozisyonTnm()
        {
            InitializeComponent();
        }

        private void frmYetkiliPozisyonTnm_Load(object sender, EventArgs e)
        {
            this.firmadakiPozisyonTableAdapter.Fill(this.yetkiliPozisyon.FirmadakiPozisyon);
            BN.BindingSource = firmadakiPozisyonBindingSource;
            Grid.DataSource = firmadakiPozisyonBindingSource;
            GridView.Columns["Id"].Visible = false;
            btnNew.PerformClick();
            GridView.OptionsSelection.MultiSelect = true;
            GridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
        }


        #region OVerride
        public override void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnNew_ItemClick(sender, e);
            firmadakiPozisyonBindingSource.CancelEdit();
            firmadakiPozisyonBindingSource.AddNew();
        }

        public override void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnSave_ItemClick(sender, e);
            firmadakiPozisyonBindingSource.EndEdit();
            firmadakiPozisyonTableAdapter.Update(yetkiliPozisyon);
        }

        public override void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnCancel_ItemClick(sender, e);
            firmadakiPozisyonBindingSource.CancelEdit();
        }

        public override void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnDelete_ItemClick(sender, e);
            if (GridView.GetSelectedRows().Length > 0)
            {
                if (XtraMessageBox.Show("Kaydı silmek istediğinize emin misiniz ?", "Sil", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    firmadakiPozisyonBindingSource.CancelEdit();
                    int[] SilId = new int[GridView.GetSelectedRows().Length];
                    for (int i = 0; i < GridView.GetSelectedRows().Length; i++)
                        if (GridView.GetDataRow(GridView.GetSelectedRows()[i]) != null)
                            SilId[i] = int.Parse(GridView.GetDataRow(GridView.GetSelectedRows()[i])["Id"].ToString());

                    for (int z = 0; z < SilId.Length; z++)
                    {
                        firmadakiPozisyonBindingSource.Filter = "Id = " + SilId[z].ToString();
                        try { firmadakiPozisyonBindingSource.RemoveCurrent(); }
                        catch { }
                    }
                    try
                    {
                        firmadakiPozisyonTableAdapter.Update(yetkiliPozisyon);
                    }
                    catch { }

                }
                firmadakiPozisyonBindingSource.Filter = "";
            }
        }

        public override void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            firmadakiPozisyonBindingSource.CancelEdit();
            base.btnClose_ItemClick(sender, e);
        }
        #endregion
    }
}
