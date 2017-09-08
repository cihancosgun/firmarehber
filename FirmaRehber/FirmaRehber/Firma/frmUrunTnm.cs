using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace FirmaRehber.Firma
{
    public partial class frmUrunTnm : FirmaRehber.BaseForm.BaseForm
    {
        public frmUrunTnm()
        {
            InitializeComponent();
        }

        private void frmUrunTnm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vwFirmaAdListDs.vwFirmaAdList' table. You can move, or remove it, as needed.
            this.vwFirmaAdListTableAdapter.Fill(this.vwFirmaAdListDs.vwFirmaAdList);            
            urunlerTableAdapter.Fill(this.urunlerDs.Urunler);
            BN.BindingSource = urunlerBindingSource;
            Grid.DataSource = urunlerBindingSource;
            GridView.Columns["Id"].Visible = false;
            btnNew.PerformClick();
            GridView.OptionsSelection.MultiSelect = true;
            GridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
        }

        #region OVerride
        public override void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnNew_ItemClick(sender, e);
            urunlerBindingSource.CancelEdit();
            urunlerBindingSource.AddNew();
        }
        public override void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ValidationProvider.Validate()) return;
            base.btnSave_ItemClick(sender, e);
            urunlerBindingSource.EndEdit();
            urunlerTableAdapter.Update(urunlerDs);
        }
        public override void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnCancel_ItemClick(sender, e);
            urunlerBindingSource.CancelEdit();

        }
        public override void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            base.btnDelete_ItemClick(sender, e);
            if (GridView.GetSelectedRows().Length > 0)
            {
                if (XtraMessageBox.Show("Kaydı silmek istediğinize emin misiniz ?", "Sil", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    urunlerBindingSource.CancelEdit();
                    int[] SilId = new int[GridView.GetSelectedRows().Length];
                    for (int i = 0; i < GridView.GetSelectedRows().Length; i++)
                        if (GridView.GetDataRow(GridView.GetSelectedRows()[i]) != null)
                            SilId[i] = int.Parse(GridView.GetDataRow(GridView.GetSelectedRows()[i])["Id"].ToString());

                    for (int z = 0; z < SilId.Length; z++)
                    {
                        urunlerBindingSource.Filter = "Id = " + SilId[z].ToString();
                        try { urunlerBindingSource.RemoveCurrent(); }
                        catch { }
                    }
                    try
                    {
                        urunlerTableAdapter.Update(urunlerDs);
                    }
                    catch { }

                }
                urunlerBindingSource.Filter = "";
            }
        }

        public override void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            urunlerBindingSource.CancelEdit();
            base.btnClose_ItemClick(sender, e);
        }
        #endregion        
    }
}
