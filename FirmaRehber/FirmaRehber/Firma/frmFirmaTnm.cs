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
    public partial class frmFirmaTnm : BaseForm.BaseForm
    {
        public frmFirmaTnm()
        {
            InitializeComponent();
        }

        private void frmFirmaTnm_Load(object sender, EventArgs e)
        {
            firmaSektorlerTableAdapter.Fill(firmaSektorlerDs.FirmaSektorler, 0);
            altSektorlerTableAdapter.Fill(sektorlerDs.AltSektorler);
            sektorlerTableAdapter.Fill(sektorlerDs.Sektorler);
            yillikCiroTableAdapter.Fill(yillikCiro.YillikCiro);
            isletmeTuruTableAdapter.Fill(isletmeTuru.IsletmeTuru);
            ilcelerTableAdapter.Fill(ilcelerDs.Ilceler);
            sehirlerTableAdapter.Fill(sehirlerDs.Sehirler);
            ulkelerTableAdapter.Fill(ulkelerDs.Ulkeler);
            firmadakiPozisyonTableAdapter.Fill(yetkiliPozisyon.FirmadakiPozisyon);

            firmalarTableAdapter.Fill(firmaRehberDataSet.Firmalar);
            BN.BindingSource = firmalarBindingSource;
            Grid.DataSource = firmalarBindingSource;
            GridView.Columns["Id"].Visible = false;
            btnNew.PerformClick();
            GridView.OptionsSelection.MultiSelect = true;
            GridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;

            firmalarTableAdapter.Adapter.RowUpdated += new SqlRowUpdatedEventHandler(frmFirmaTnm_RowUpdated);
            firmalarBindingSource.CurrentChanged += new EventHandler(firmalarBindingSource_CurrentChanged);
        }


        void firmalarBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (!(firmalarBindingSource.Current as DataRowView).Row.IsNull("Id"))
                {
                    firmaSektorlerTableAdapter.Fill(firmaSektorlerDs.FirmaSektorler, (int)(firmalarBindingSource.Current as DataRowView).Row["Id"]);
                }
            }
            catch { }
        }

        #region OVerride
        public override void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnNew_ItemClick(sender, e);
            firmalarBindingSource.CancelEdit();
            firmalarBindingSource.AddNew();
            ulkeLookUpEdit.Refresh();
            ulkeLookUpEdit.EditValue = ulkeLookUpEdit.Properties.GetDataSourceValue("ADI", 0);
        }
        public override void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ValidationProvider.Validate()) return;
            base.btnSave_ItemClick(sender, e);
            firmalarBindingSource.EndEdit();
            firmaSektorlerBindingSource.EndEdit();

            firmalarTableAdapter.Update(firmaRehberDataSet);

            try
            {
                foreach (DataRow item in firmaSektorlerDs.FirmaSektorler.Rows)
                {
                    if (item.RowState == DataRowState.Added || item.RowState == DataRowState.Modified)
                    {
                        item["FirmaRef"] = (firmalarBindingSource.Current as DataRowView)["Id"];
                    }
                }
            }
            catch { }

            firmaSektorlerTableAdapter.Update(firmaSektorlerDs);
        }
        public override void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnCancel_ItemClick(sender, e);
            firmalarBindingSource.CancelEdit();
            firmaSektorlerBindingSource.CancelEdit();

        }
        void frmFirmaTnm_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
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
                            (firmalarBindingSource.Current as DataRowView)["Id"] = NewID;
                        }
                        catch { }
                    }
                }
            }
            catch { }
        }
        public override void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnDelete_ItemClick(sender, e);
            if (GridView.GetSelectedRows().Length > 0)
            {
                if (XtraMessageBox.Show("Kaydı silmek istediğinize emin misiniz ?", "Sil", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    firmalarBindingSource.CancelEdit();
                    int[] SilId = new int[GridView.GetSelectedRows().Length];
                    for (int i = 0; i < GridView.GetSelectedRows().Length; i++)
                        if (GridView.GetDataRow(GridView.GetSelectedRows()[i]) != null)
                            SilId[i] = int.Parse(GridView.GetDataRow(GridView.GetSelectedRows()[i])["Id"].ToString());

                    for (int z = 0; z < SilId.Length; z++)
                    {
                        firmalarBindingSource.Filter = "Id = " + SilId[z].ToString();
                        try { firmalarBindingSource.RemoveCurrent(); }
                        catch { }
                    }
                    try
                    {
                        firmalarTableAdapter.Update(firmaRehberDataSet);
                    }
                    catch { }

                }
                firmalarBindingSource.Filter = "";
            }
        }

        public override void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            firmalarBindingSource.CancelEdit();
            firmaSektorlerBindingSource.CancelEdit();
            base.btnClose_ItemClick(sender, e);
        }
        #endregion

        private void btnSec_Click(object sender, EventArgs e)
        {
            try
            {
                grdAltSektor.SelectedRowsCount.ToString();
                DevExpress.XtraGrid.Views.Grid.GridView gw = (grdSektor.GetVisibleDetailView(grdSektor.FocusedRowHandle) as DevExpress.XtraGrid.Views.Grid.GridView);
                if (gridControl1.FocusedView.Name == grdAltSektor.Name && gw.IsValidRowHandle(gw.FocusedRowHandle))
                {
                    DataRowView drwNew = (DataRowView)firmaSektorlerBindingSource.AddNew();
                    drwNew["Sektor"] = gw.GetRowCellValue(gw.FocusedRowHandle, "AltSektor").ToString();
                    firmaSektorlerBindingSource.EndEdit();
                }
                else if (gridControl1.FocusedView.Name == grdSektor.Name && grdSektor.IsValidRowHandle(grdSektor.FocusedRowHandle))
                {
                    DataRowView drwNew = (DataRowView)firmaSektorlerBindingSource.AddNew();
                    drwNew["Sektor"] = grdSektor.GetDataRow(grdSektor.FocusedRowHandle)["Sektor"].ToString();
                    firmaSektorlerBindingSource.EndEdit();
                }
            }
            catch { }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdFirmaSektor.IsValidRowHandle(grdFirmaSektor.FocusedRowHandle) && MessageBox.Show("Silmek istediğinize emin misiniz ?", "Satır Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    grdFirmaSektor.DeleteRow(grdFirmaSektor.FocusedRowHandle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmFirmaTnm_StateChanged(object sender, EventArgs e)
        {
        }

        private void btnLogoTemizle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logoPictureEdit.Image = null;
        }

        private void btnLogoSec_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logoPictureEdit.LoadImage();
        }

        private void ulkeLookUpEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                using (Tanimlar.frmUlkeler frm = new Tanimlar.frmUlkeler())
                {
                    frm.ulkelerDs = ulkelerDs;
                    frm.ulkelerTableAdapter = ulkelerTableAdapter;
                    frm.ulkelerBindingSource.DataSource = frm.ulkelerDs.Ulkeler;
                    frm.ShowDialog();
                }
            }
        }

        private void sehirLookUpEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                using (Tanimlar.frmSehirler frm = new Tanimlar.frmSehirler())
                {
                    frm.sehirlerDs = sehirlerDs;
                    frm.sehirlerTableAdapter = sehirlerTableAdapter;
                    frm.sehirlerBindingSource.DataSource = frm.sehirlerDs.Sehirler;
                    frm.ShowDialog();
                }
            }
        }

        private void ilceLookUpEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                using (Tanimlar.frmIlceler frm = new Tanimlar.frmIlceler())
                {
                    frm.ilcelerDs = ilcelerDs;
                    frm.ilcelerTableAdapter = ilcelerTableAdapter;
                    frm.ilcelerBindingSource.DataSource = frm.ilcelerDs.Ilceler;
                    frm.ShowDialog();
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (Tanimlar.frmSektorler frm = new Tanimlar.frmSektorler())
            {
                frm.sektorlerDs = sektorlerDs;
                frm.sektorlerTableAdapter = sektorlerTableAdapter;
                frm.altSektorlerTableAdapter = altSektorlerTableAdapter;
                frm.sektorlerBindingSource.DataSource = frm.sektorlerDs.Sektorler;
                frm.ShowDialog();
            }
        }

        private void yetkiliPozisyonLookUpEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                using (Tanimlar.frmYetkiliPozisyonTnm frm = new Tanimlar.frmYetkiliPozisyonTnm())
                {
                    frm.yetkiliPozisyon = yetkiliPozisyon;
                    frm.firmadakiPozisyonTableAdapter = firmadakiPozisyonTableAdapter;
                    frm.firmadakiPozisyonBindingSource.DataSource = frm.yetkiliPozisyon.FirmadakiPozisyon;
                    frm.ShowDialog();
                }
            }
        }

        private void isletmeTuruLookUpEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                using (Tanimlar.frmIsletmeTuru frm = new Tanimlar.frmIsletmeTuru())
                {
                    frm.isletmeTuru = isletmeTuru;
                    frm.isletmeTuruTableAdapter = isletmeTuruTableAdapter;
                    frm.isletmeTuruBindingSource.DataSource = frm.isletmeTuru.IsletmeTuru;
                    frm.ShowDialog();
                }
            }
        }

        private void yillikCiroLookUpEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                using (Tanimlar.frmYillikCiroTnm frm = new Tanimlar.frmYillikCiroTnm())
                {
                    frm.yillikCiro = yillikCiro;
                    frm.yillikCiroTableAdapter = yillikCiroTableAdapter;
                    frm.yillikCiroBindingSource.DataSource = frm.yillikCiro.YillikCiro;
                    frm.ShowDialog();
                }
            }
        }
    }
}
