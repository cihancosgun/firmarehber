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
    public partial class frmIsletmeTuru : FirmaRehber.BaseForm.BaseForm
    {
        public isletmeTuru isletmeTuru = null;
        public isletmeTuruTableAdapters.IsletmeTuruTableAdapter isletmeTuruTableAdapter = null;

        public frmIsletmeTuru()
        {
            InitializeComponent();
        }

        private void frmIsletmeTuru_Load(object sender, EventArgs e)
        {
            this.isletmeTuruTableAdapter.Fill(this.isletmeTuru.IsletmeTuru);
            BN.BindingSource = isletmeTuruBindingSource;
            Grid.DataSource = isletmeTuruBindingSource;
            GridView.Columns["Id"].Visible = false;
            btnNew.PerformClick();
            GridView.OptionsSelection.MultiSelect = true;
            GridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
        }


        #region OVerride
        public override void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnNew_ItemClick(sender, e);
            isletmeTuruBindingSource.CancelEdit();
            isletmeTuruBindingSource.AddNew();
        }

        public override void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnSave_ItemClick(sender, e);
            isletmeTuruBindingSource.EndEdit();
            isletmeTuruTableAdapter.Update(isletmeTuru);
        }

        public override void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnCancel_ItemClick(sender, e);
            isletmeTuruBindingSource.CancelEdit();
        }

        public override void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnDelete_ItemClick(sender, e);
            if (GridView.GetSelectedRows().Length > 0)
            {
                if (XtraMessageBox.Show("Kaydı silmek istediğinize emin misiniz ?", "Sil", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    isletmeTuruBindingSource.CancelEdit();
                    int[] SilId = new int[GridView.GetSelectedRows().Length];
                    for (int i = 0; i < GridView.GetSelectedRows().Length; i++)
                        if (GridView.GetDataRow(GridView.GetSelectedRows()[i]) != null)
                            SilId[i] = int.Parse(GridView.GetDataRow(GridView.GetSelectedRows()[i])["Id"].ToString());

                    for (int z = 0; z < SilId.Length; z++)
                    {
                        isletmeTuruBindingSource.Filter = "Id = " + SilId[z].ToString();
                        try { isletmeTuruBindingSource.RemoveCurrent(); }
                        catch { }
                    }
                    try
                    {
                        isletmeTuruTableAdapter.Update(isletmeTuru);
                    }
                    catch { }

                }
                isletmeTuruBindingSource.Filter = "";
            }
        }

        public override void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            isletmeTuruBindingSource.CancelEdit();
            base.btnClose_ItemClick(sender, e);
        }
        #endregion
    }
}
