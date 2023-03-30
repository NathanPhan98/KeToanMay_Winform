using ManWo_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManWo_Accounting
{
    public partial class FormListPhieu : Form
    {
        //public choice send;
        private OleDbDataAdapter objAdapter;
        private DataSet ds;
        frmSearchKhachHang search = new frmSearchKhachHang();

        public FormListPhieu()
        {
            InitializeComponent();
        }

        private void FormListPhieu_Load(object sender, EventArgs e)
        {
            showData(AppEnv.Phieu);
        }

        private void showData(string Phieu)
        {
            //string query = "select * from " + Phieu + " where between "+ AppEnv.dTuNgay+" and ";
            string query = "set dateformat dmy select* from "+ Phieu +" where dNgayChungTu between '" + AppEnv.dTuNgay.Date.ToShortDateString() + "' and '" + AppEnv.dDenNgay.Date.ToShortDateString() + "' order by dNgayChungTu";


            ds = new DataSet();
            objAdapter = new OleDbDataAdapter(query, AppEnv.WorkDB);
            objAdapter.Fill(ds, Phieu);
            dgvDSPhieu.DataSource = ds.Tables[Phieu];
        }

        int vt = -1;
        private void dgvDSPhieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;
            int indexRow = dgvDSPhieu.CurrentCell.RowIndex;
            //this.send(row["cMaKhachHang"].ToString(), row["cMaSoThue"].ToString(), row["cTenKhachHang"].ToString());
            AppEnv.maCTXHSearch = vt;
            MessageBox.Show(vt.ToString());
            this.Close();
        }

        private void dgvDSPhieu_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.F)
            {
                if (AppEnv.FormOpen == false)
                {
                    search.Show();
                    AppEnv.FormOpen = true;
                    search.Btn_Search_Press += Btn_Search_Press;
                    search.Btn_Previous_Press += Btn_Search_Press;
                    search.Btn_Next_Press += Btn_Search_Press;
                    search.FormClosed += Search_FormClosed;
                }
            }
        }

        //Event catch btn_search in frmSearchKhachHang press
        private void Btn_Search_Press()
        {
            var row = dgvDSPhieu.Rows.Cast<DataGridViewRow>()
                .Where(x => !x.IsNewRow)
                .Where(x => ((DataRowView)x.DataBoundItem)["cMaChungTu"].ToString().Equals(search.searchValue))
                .FirstOrDefault();
            this.dgvDSPhieu.CurrentCell = row.Cells[0];
        }

        private void Search_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppEnv.FormOpen = false;
        }

        
    }
}
