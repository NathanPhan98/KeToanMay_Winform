using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using ManWo_Lib;

namespace ManWo_Accounting
{
    public partial class FormTaiKhoan : Form
    {
        private OleDbDataAdapter objAdapter;
        private DataSet ds;

        public FormTaiKhoan()
        {
            InitializeComponent();
        }

        public void ConfigDanhMucGripView()
        {
            HangHoaGridView.ReadOnly = true;
            HangHoaGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void showData()
        {
            string query = "select * from tDanhMucTaiKhoan";

            ds = new DataSet();
            objAdapter = new OleDbDataAdapter(query, AppEnv.WorkDB);
            objAdapter.Fill(ds, "tDanhMucTaiKhoan");
            HangHoaGridView.DataSource = ds.Tables["tDanhMucTaiKhoan"];
            HangHoaGridView.Columns[0].HeaderText = "Tài khoản";
            HangHoaGridView.Columns[1].HeaderText = "Tên tài khoản";
            HangHoaGridView.Columns[2].HeaderText = "Số dư nợ đầu";
            HangHoaGridView.Columns[3].HeaderText = "Số dư có đầu";
            HangHoaGridView.Columns[4].HeaderText = "Có định khoản";
            HangHoaGridView.Columns[5].HeaderText = "Cấp";
            HangHoaGridView.Columns[6].HeaderText = "Ngày số dư";

            ConfigDanhMucGripView();
        }

        public void focusFirstRow()
        {
            HangHoaGridView.CurrentCell = HangHoaGridView.Rows[0].Cells[0];
            HangHoaGridView.CurrentCell.Selected = true;
        }

        private void HangHoaGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            showData();
            focusFirstRow();
        }

        private void btnInDS_Click(object sender, EventArgs e)
        {
            Form frm = new report.frmReportTK();
            frm.ShowDialog();
        }
    }
}
