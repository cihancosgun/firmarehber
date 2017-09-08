using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FirmaRehber.Tanimlar
{
    public partial class frmSektorler : Form
    {
        public sektorlerDs sektorlerDs = null;
        public sektorlerDsTableAdapters.SektorlerTableAdapter sektorlerTableAdapter = null;
        public sektorlerDsTableAdapters.AltSektorlerTableAdapter altSektorlerTableAdapter = null;

        public frmSektorler()
        {
            InitializeComponent();
        }

        private void frmSektorler_Load(object sender, EventArgs e)
        {
            
        }

       
        private void barLargeButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Validate();
            this.sektorlerBindingSource.EndEdit();
            this.sektorlerTableAdapter.Update(this.sektorlerDs.Sektorler);
            this.altSektorlerTableAdapter.Update(this.sektorlerDs.AltSektorler);
        }

        private void barLargeButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sektorlerBindingSource.CancelEdit();
            this.Close();
        }
    }
}
