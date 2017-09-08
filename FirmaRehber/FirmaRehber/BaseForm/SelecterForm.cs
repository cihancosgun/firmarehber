using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace FirmaRehber.BaseForm
{
    public partial class SelecterForm : XtraForm
    {
        public SelecterForm()
        {
            InitializeComponent();
        }



        DataTable GetList(string Sql)
        {
            DataTable dtNew = new DataTable();
            using (OleDbConnection con = new OleDbConnection(Properties.Settings.Default.DataConnectionString1))
            {
                OleDbDataAdapter da = new OleDbDataAdapter(Sql, con);
                da.Fill(dtNew);
            }
            return dtNew;
        }

        string _IdColumn = "Id";
        [Category("Liste")]
        public string IdColumn
        {
            get { return _IdColumn; }
            set { _IdColumn = value; }
        }


        string _ListeSql = "";
        [Category("Liste")]
        public string ListeSql
        {
            get { return _ListeSql; }
            set
            {
                _ListeSql = value;
            }
        }

        string _SearchColumn = "";
        [Category("Liste")]
        public string SearchColumn
        {
            get { return _SearchColumn; }
            set { _SearchColumn = value; }
        }

        string _Secilen = "";
        [Category("Liste")]
        public string Secilen
        {
            get { return _Secilen; }
            set { _Secilen = value; }
        }

        string[] _Secilenler = null;
        [Category("Liste")]
        public string[] Secilenler
        {
            get { return _Secilenler; }
            set { _Secilenler = value; }
        }


        bool _CokluSecim = false;
        [Category("Liste")]
        public bool CokluSecim
        {
            get { return _CokluSecim; }
            set { _CokluSecim = value; gridView1.OptionsSelection.MultiSelect = value; gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect; }
        }

        private void SelecterForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = GetList(ListeSql);
            if (gridView1.Columns[_IdColumn] != null)
            {
                gridView1.Columns[_IdColumn].Visible = false;
            }
        }

        private void txtFind_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            gridView1.Columns.Clear();
            GC.Collect();
            if (e.NewValue == null || string.IsNullOrEmpty(e.NewValue.ToString()))
                gridControl1.DataSource = GetList(ListeSql);
            else
                gridControl1.DataSource = GetList(ListeSql + " Where " + SearchColumn + " Like '%" + e.NewValue.ToString() + "%'");

            gridView1.Columns[_IdColumn].Visible = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Secilen = gridView1.GetDataRow(e.FocusedRowHandle)[_IdColumn].ToString();
            }
            catch
            {
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            try
            {
                Secilen = gridView1.GetDataRow(gridView1.FocusedRowHandle)[_IdColumn].ToString();
            }
            catch
            {
            }
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {


        }

        private void SelecterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (DialogResult == System.Windows.Forms.DialogResult.OK && CokluSecim)
                {
                    int[] selectedRows = gridView1.GetSelectedRows();
                    Secilenler = null;
                    if (selectedRows != null && selectedRows.Length > 0)
                    {
                        Secilenler = new string[selectedRows.Length];
                        for (int i = 0; i < selectedRows.Length; i++)
                        {
                            try
                            {
                                Secilenler[i] = gridView1.GetDataRow(selectedRows[i])[_IdColumn].ToString();
                                Secilen = "";
                                foreach (string item in Secilenler)
                                    Secilen += item + ",";
                                Secilen = Secilen.Remove(Secilen.Length - 1);
                            }
                            catch { }
                        }
                    }
                }
            }
            catch { }
        }
    }
}
