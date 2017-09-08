using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;

namespace FirmaRehber
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(Properties.Settings.Default.Tema))
                Properties.Settings.Default.Tema = defaultLookAndFeel1.LookAndFeel.SkinName;
            beTema.EditValue = Properties.Settings.Default.Tema;
            defaultLookAndFeel1.LookAndFeel.SkinName = beTema.EditValue.ToString();
            beTema.EditValue = defaultLookAndFeel1.LookAndFeel.SkinName;
            DevExpress.Skins.SkinManager.EnableFormSkins();
            ribbonControl1.SelectedPage = ribbonPage1;
            /*if (Program.IsDemo)
            {
                barButtonItem7.Enabled = false;
                barButtonItem13.Enabled = false;
                barButtonItem14.Enabled = false;
                this.Text += "----Demo";
            }
            else
            {
                ribbonPageGroup8.Visible = false;
            }*/

            frmBack fbck = new frmBack();
            fbck.MdiParent = this;
            fbck.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblBugun.Caption = DateTime.Now.ToString();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = XtraMessageBox.Show("Programdan çıkmak istediğinize emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No;
        }

        private void beTema_EditValueChanged(object sender, EventArgs e)
        {
            defaultLookAndFeel1.LookAndFeel.SkinName = beTema.EditValue.ToString();
            Properties.Settings.Default.Tema = beTema.EditValue.ToString();
            Properties.Settings.Default.Save();
            DevExpress.Skins.SkinManager.EnableFormSkins();
        }

        private void ribbonControl1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Tag != null && !string.IsNullOrEmpty(e.Item.Tag.ToString()))
            {
                Type tpFind = null;
                foreach (System.Reflection.Assembly item in AppDomain.CurrentDomain.GetAssemblies())
                {
                    foreach (Type item2 in item.GetTypes())
                    {
                        if (item2.Name.Equals(e.Item.Tag.ToString()))
                        {
                            tpFind = item2;
                            break;
                        }
                    }
                }
                if (tpFind != null)
                {
                    Form frm = (Form)System.Activator.CreateInstance(tpFind);

                    frm.MdiParent = this;
                    frm.Show();

                    //tpFind = null;
                    //GC.Collect();
                }
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AboutBox frma = new AboutBox();
            frma.ShowDialog();
            frma.Dispose();
            GC.Collect();
        }
    }
}
