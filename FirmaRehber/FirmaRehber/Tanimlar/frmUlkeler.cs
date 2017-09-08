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
    public partial class frmUlkeler : FirmaRehber.BaseForm.BaseForm
    {

        public ulkelerDs ulkelerDs = null;
        public ulkelerDsTableAdapters.UlkelerTableAdapter ulkelerTableAdapter = null;

        public frmUlkeler()
        {
            InitializeComponent();
        }

        private void frmUlkeler_Load(object sender, EventArgs e)
        {            
            BN.BindingSource = ulkelerBindingSource;
            Grid.DataSource = ulkelerBindingSource;
            btnNew.PerformClick();
            GridView.OptionsSelection.MultiSelect = true;
            GridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
        }

        #region OVerride
        public override void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnNew_ItemClick(sender, e);
            ulkelerBindingSource.CancelEdit();
            ulkelerBindingSource.AddNew();
        }

        public override void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnSave_ItemClick(sender, e);
            ulkelerBindingSource.EndEdit();
            ulkelerTableAdapter.Update(ulkelerDs);
        }

        public override void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnCancel_ItemClick(sender, e);
            ulkelerBindingSource.CancelEdit();
        }

        public override void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnDelete_ItemClick(sender, e);
            if (GridView.GetSelectedRows().Length > 0)
            {
                if (XtraMessageBox.Show("Kaydı silmek istediğinize emin misiniz ?", "Sil", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    ulkelerBindingSource.CancelEdit();
                    int[] SilId = new int[GridView.GetSelectedRows().Length];
                    for (int i = 0; i < GridView.GetSelectedRows().Length; i++)
                        if (GridView.GetDataRow(GridView.GetSelectedRows()[i]) != null)
                            SilId[i] = int.Parse(GridView.GetDataRow(GridView.GetSelectedRows()[i])["KODU"].ToString());

                    for (int z = 0; z < SilId.Length; z++)
                    {
                        ulkelerBindingSource.Filter = "KODU = " + SilId[z].ToString();
                        try { ulkelerBindingSource.RemoveCurrent(); }
                        catch { }
                    }
                    try
                    {
                        ulkelerTableAdapter.Update(ulkelerDs);
                    }
                    catch { }

                }
                ulkelerBindingSource.Filter = "";
            }
        }

        public override void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ulkelerBindingSource.CancelEdit();
            base.btnClose_ItemClick(sender, e);
        }
        #endregion
    }
}
