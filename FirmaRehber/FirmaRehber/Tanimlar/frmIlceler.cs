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
    public partial class frmIlceler : FirmaRehber.BaseForm.BaseForm
    {        
        public ilcelerDs ilcelerDs = null;
        public ilcelerDsTableAdapters.IlcelerTableAdapter ilcelerTableAdapter = null;

        public frmIlceler()
        {
            InitializeComponent();
        }

        private void frmIlceler_Load(object sender, EventArgs e)
        {            
            this.sehirlerTableAdapter.Fill(this.sehirlerDs.Sehirler);
            BN.BindingSource = ilcelerBindingSource;
            Grid.DataSource = ilcelerBindingSource;
            GridView.Columns["Id"].Visible = false;
            GridView.Columns["UstId"].ColumnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit() { DataSource = sehirlerBindingSource, DisplayMember = "Sehir", ValueMember = "Id" };
            btnNew.PerformClick();
            GridView.OptionsSelection.MultiSelect = true;
            GridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
        }


        #region OVerride
        public override void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnNew_ItemClick(sender, e);
            ilcelerBindingSource.CancelEdit();
            ilcelerBindingSource.AddNew();
        }

        public override void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnSave_ItemClick(sender, e);
            ilcelerBindingSource.EndEdit();
            ilcelerTableAdapter.Update(ilcelerDs);
        }

        public override void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnCancel_ItemClick(sender, e);
            ilcelerBindingSource.CancelEdit();
        }

        public override void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnDelete_ItemClick(sender, e);
            if (GridView.GetSelectedRows().Length > 0)
            {
                if (XtraMessageBox.Show("Kaydı silmek istediğinize emin misiniz ?", "Sil", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    ilcelerBindingSource.CancelEdit();
                    int[] SilId = new int[GridView.GetSelectedRows().Length];
                    for (int i = 0; i < GridView.GetSelectedRows().Length; i++)
                        if (GridView.GetDataRow(GridView.GetSelectedRows()[i]) != null)
                            SilId[i] = int.Parse(GridView.GetDataRow(GridView.GetSelectedRows()[i])["Id"].ToString());

                    for (int z = 0; z < SilId.Length; z++)
                    {
                        ilcelerBindingSource.Filter = "Id = " + SilId[z].ToString();
                        try { ilcelerBindingSource.RemoveCurrent(); }
                        catch { }
                    }
                    try
                    {
                        ilcelerTableAdapter.Update(ilcelerDs);
                    }
                    catch { }

                }
                ilcelerBindingSource.Filter = "";
            }
        }

        public override void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ilcelerBindingSource.CancelEdit();
            base.btnClose_ItemClick(sender, e);
        }
        #endregion
    }
}
