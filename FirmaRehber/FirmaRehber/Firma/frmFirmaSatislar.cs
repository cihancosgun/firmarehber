using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace FirmaRehber.Firma
{
    public partial class frmFirmaSatislar : FirmaRehber.BaseForm.BaseForm
    {
        public frmFirmaSatislar()
        {
            InitializeComponent();
        }

        private void frmFirmaSatislar_Load(object sender, EventArgs e)
        {
            vwFirmaAdListTableAdapter.Fill(vwFirmaAdListDs.vwFirmaAdList);
            urunlerTableAdapter.Fill(urunlerDs.Urunler);
            firmaSatislarKalemTableAdapter.Fill(firmaSatislarDs.FirmaSatislarKalem);
            firmaSatislarTableAdapter.Fill(firmaSatislarDs.FirmaSatislar);


            BN.BindingSource = firmaSatislarBindingSource;
            Grid.DataSource = firmaSatislarBindingSource;
            GridView.Columns["Id"].Visible = false;
            GridView.Columns["FirmaRef"].Caption = "Firma";
            GridView.Columns["FirmaRef"].ColumnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit() { DataSource = vwFirmaAdListBindingSource, DisplayMember = "FirmaAd", ValueMember = "Id", };

            btnNew.PerformClick();
            GridView.OptionsSelection.MultiSelect = true;
            GridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;

            firmaSatislarTableAdapter.Adapter.RowUpdated += new System.Data.SqlClient.SqlRowUpdatedEventHandler(firimaSatis_RowUpdated);
        }

        void firimaSatis_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {
            try
            {
                if (e.Row.RowState == DataRowState.Added)
                {
                    using (SqlCommand cmd = new SqlCommand("Select @@Identity", e.Command.Connection))
                    {
                        object NewID = cmd.ExecuteScalar();

                        try
                        {
                            (firmaSatislarBindingSource.Current as DataRowView)["Id"] = NewID;
                        }
                        catch { }
                    }
                }
            }
            catch { }
        }


        #region OVerride
        public override void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnNew_ItemClick(sender, e);
            firmaSatislarBindingSource.CancelEdit();
            firmaSatislarBindingSource.AddNew();
        }
        public override void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ValidationProvider.Validate()) return;
            base.btnSave_ItemClick(sender, e);
            firmaSatislarBindingSource.EndEdit();
            firmaSatislarKalemBindingSource.EndEdit();

            firmaSatislarTableAdapter.Update(firmaSatislarDs);

            try
            {
                foreach (DataRow item in firmaSatislarDs.FirmaSatislarKalem.Rows)
                {
                    if (item.RowState == DataRowState.Added || item.RowState == DataRowState.Modified)
                    {
                        item["FirmaSatisRef"] = (firmaSatislarBindingSource.Current as DataRowView)["Id"];
                    }
                }
            }
            catch { }

            firmaSatislarKalemTableAdapter.Update(firmaSatislarDs.FirmaSatislarKalem);
        }
        public override void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnCancel_ItemClick(sender, e);
            firmaSatislarBindingSource.CancelEdit();
            firmaSatislarKalemBindingSource.CancelEdit();

        }
        public override void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnDelete_ItemClick(sender, e);
            if (GridView.GetSelectedRows().Length > 0)
            {
                if (XtraMessageBox.Show("Kaydı silmek istediğinize emin misiniz ?", "Sil", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    firmaSatislarBindingSource.CancelEdit();
                    int[] SilId = new int[GridView.GetSelectedRows().Length];
                    for (int i = 0; i < GridView.GetSelectedRows().Length; i++)
                        if (GridView.GetDataRow(GridView.GetSelectedRows()[i]) != null)
                            SilId[i] = int.Parse(GridView.GetDataRow(GridView.GetSelectedRows()[i])["Id"].ToString());

                    for (int z = 0; z < SilId.Length; z++)
                    {
                        firmaSatislarBindingSource.Filter = "Id = " + SilId[z].ToString();
                        try { firmaSatislarBindingSource.RemoveCurrent(); }
                        catch { }
                    }
                    try
                    {
                        firmaSatislarTableAdapter.Update(firmaSatislarDs);
                    }
                    catch { }

                }
                firmaSatislarBindingSource.Filter = "";
            }
        }

        public override void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            firmaSatislarBindingSource.CancelEdit();
            firmaSatislarKalemBindingSource.CancelEdit();
            base.btnClose_ItemClick(sender, e);
        }
        #endregion
    }
}
