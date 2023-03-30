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
    public partial class FormKhachHang : Form
    {
        private OleDbDataAdapter objAdapter;
        private DataSet ds;
        private int Mode = 0; 
        public FormKhachHang()
        {
            InitializeComponent();

            this.MouseWheel += FormKhachHang_MouseWheel;
        }

        //Xu ly lan chuot
        private void FormKhachHang_MouseWheel(object sender, MouseEventArgs e)
        {
            int deltaScroll = 10;

            if (e.Delta > 0)
            {
                if (this.VerticalScroll.Value - deltaScroll >= this.VerticalScroll.Minimum)
                    this.VerticalScroll.Value -= deltaScroll;
                else
                    this.VerticalScroll.Value = this.VerticalScroll.Minimum;
            }
            else
            {
                if (this.VerticalScroll.Value + deltaScroll <= this.VerticalScroll.Maximum)
                    this.VerticalScroll.Value += deltaScroll;
                else
                    this.VerticalScroll.Value = this.VerticalScroll.Maximum;
            }
        }

        public void ConfigDanhMucGripView()
        {
            KhachHangGridView.ReadOnly = true;
            KhachHangGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void showData()
        {
            string query = "select * from tDanhMucKhachHang";

            ds = new DataSet();
            objAdapter = new OleDbDataAdapter(query, AppEnv.WorkDB);
            objAdapter.Fill(ds, "tDanhMucKhachHang");
            KhachHangGridView.DataSource = ds.Tables["tDanhMucKhachHang"];
            KhachHangGridView.Columns[0].HeaderText = "Mã khách hàng";
            KhachHangGridView.Columns[1].HeaderText = "Tên khách hàng";
            KhachHangGridView.Columns[2].HeaderText = "Mã số thuế";
            KhachHangGridView.Columns[3].HeaderText = "Địa chỉ";
            KhachHangGridView.Columns[4].HeaderText = "Tỉnh thành phố";
            KhachHangGridView.Columns[5].HeaderText = "Điện thoại";
            KhachHangGridView.Columns[6].HeaderText = "Fax";

            ConfigDanhMucGripView();
        }

        public bool ManageCustomer(string ma, string ten, string sothue, string diachi, string thanhpho, string dt, string fax, int mode)
        {
            
            bool QueryState = false;

            try
            {
                OleDbCommand commannd = new OleDbCommand("p_QuanLyDanhMucKH", AppEnv.WorkDB);
                if (ma == "")
                {
                    MessageBox.Show("Mã khách hàng TRỐNG", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QueryState = false;
                }
                else
                {
                    commannd.Parameters.AddWithValue("@c_makh", ma);
                    commannd.Parameters.AddWithValue("@c_tenkh", ten);
                    commannd.Parameters.AddWithValue("@c_msthue", sothue);
                    commannd.Parameters.AddWithValue("@c_diachi", diachi);
                    commannd.Parameters.AddWithValue("@c_thanhpho", thanhpho);
                    commannd.Parameters.AddWithValue("@c_dienthoai", dt);
                    commannd.Parameters.AddWithValue("@c_fax", fax);
                    commannd.Parameters.AddWithValue("@Mode", mode);

                    commannd.CommandType = CommandType.StoredProcedure;

                    commannd.ExecuteNonQuery();

                    QueryState = true;
                }
            }
            catch
            {
                MessageBox.Show("Mã khách hàng đã tồn tại");
            }

            return QueryState;
        }


        private void FormKhachHang_MouseLeave(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void FormKhachHang_MouseEnter(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            txt_maKH.Enabled = false;
            txt_tenKH.Enabled = false;
            txt_diachi.Enabled = false;
            txt_thanhpho.Enabled = false;
            txt_sothue.Enabled = false;
            txt_dt.Enabled = false;
            txt_fax.Enabled = false;
            showData();
        }

        private void btn_them_KhachHang_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btn_sua_KhachHang_Click(object sender, EventArgs e)
        {
            

        }

        private void KhachHangGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            int indexRow = KhachHangGridView.CurrentCell.RowIndex;
            txt_maKH.Text = KhachHangGridView.Rows[indexRow].Cells[0].Value.ToString();
            txt_tenKH.Text = KhachHangGridView.Rows[indexRow].Cells[1].Value.ToString();
            txt_sothue.Text = KhachHangGridView.Rows[indexRow].Cells[2].Value.ToString();
            txt_diachi.Text = KhachHangGridView.Rows[indexRow].Cells[3].Value.ToString();
            txt_thanhpho.Text = KhachHangGridView.Rows[indexRow].Cells[4].Value.ToString();
            txt_dt.Text = KhachHangGridView.Rows[indexRow].Cells[5].Value.ToString();
            txt_fax.Text = KhachHangGridView.Rows[indexRow].Cells[6].Value.ToString();
        }
        private void btn_xoa_Khachhang_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_in_KhachHang_Click(object sender, EventArgs e)
        {
            Form fReport = new report.frmReportKH();
            fReport.ShowDialog();
        }

        private void btn_them_KhachHang_Click_1(object sender, EventArgs e)
        {
            if (btn_them_KhachHang.Tag == null)
            {
                //Mode 1 = Insert data
                Mode = 1;

                btn_them_KhachHang.Tag = "toogled";

                txt_maKH.Enabled = true;
                txt_tenKH.Enabled = true;
                txt_diachi.Enabled = true;
                txt_thanhpho.Enabled = true;
                txt_sothue.Enabled = true;
                txt_dt.Enabled = true;
                txt_fax.Enabled = true;

                //clear data
                txt_maKH.Text = "";
                txt_tenKH.Text = "";
                txt_diachi.Text = "";
                txt_thanhpho.Text = "";
                txt_sothue.Text = "";
                txt_dt.Text = "";
                txt_fax.Text = "";

                btn_them_KhachHang.Text = "GHI";
            }
            else
            {
                if (Mode != 0 && Mode == 1)
                {
                    bool Result = ManageCustomer(txt_maKH.Text, txt_tenKH.Text, txt_sothue.Text,
                    txt_diachi.Text, txt_thanhpho.Text, txt_dt.Text, txt_fax.Text, Mode);
                    if (Result == true)
                    {
                        MessageBox.Show("Thêm thành công khách hàng");
                    }
                    else
                    {
                        txt_maKH.Text = "";
                        txt_tenKH.Text = "";
                        txt_sothue.Text = "";
                        txt_diachi.Text = "";
                        txt_thanhpho.Text = "";
                        txt_dt.Text = "";
                        txt_fax.Text = "";
                    }
                }
                else if (Mode != 0 && Mode == 2)
                {
                    //Mode 2 = Update data
                    bool Result = ManageCustomer(txt_maKH.Text, txt_tenKH.Text, txt_sothue.Text,
                    txt_diachi.Text, txt_thanhpho.Text, txt_dt.Text, txt_fax.Text, Mode);
                    if (Result == true)
                    {
                        MessageBox.Show("Sửa thành công khách hàng");
                    }
                }

                btn_them_KhachHang.Tag = null;
                txt_maKH.Enabled = false;
                txt_tenKH.Enabled = false;
                txt_diachi.Enabled = false;
                txt_thanhpho.Enabled = false;
                txt_sothue.Enabled = false;
                txt_dt.Enabled = false;
                txt_fax.Enabled = false;
                btn_them_KhachHang.Text = "THÊM";

                showData();
            }
        }

        private void btn_sua_KhachHang_Click_1(object sender, EventArgs e)
        {
            //Mode 2 = Update data
            Mode = 2;
            if (btn_them_KhachHang.Tag == null)
            {
                btn_them_KhachHang.Tag = "toogled";
                txt_tenKH.Enabled = true;
                txt_diachi.Enabled = true;
                txt_thanhpho.Enabled = true;
                txt_sothue.Enabled = true;
                txt_dt.Enabled = true;
                txt_fax.Enabled = true;
                btn_them_KhachHang.Text = "GHI";
            }
            else
            {
                int indexRow = KhachHangGridView.CurrentCell.RowIndex;
                txt_maKH.Text = KhachHangGridView.Rows[indexRow].Cells[0].Value.ToString();
                txt_tenKH.Text = KhachHangGridView.Rows[indexRow].Cells[1].Value.ToString();
                txt_sothue.Text = KhachHangGridView.Rows[indexRow].Cells[2].Value.ToString();
                txt_diachi.Text = KhachHangGridView.Rows[indexRow].Cells[3].Value.ToString();
                txt_thanhpho.Text = KhachHangGridView.Rows[indexRow].Cells[4].Value.ToString();
                txt_dt.Text = KhachHangGridView.Rows[indexRow].Cells[5].Value.ToString();
                txt_fax.Text = KhachHangGridView.Rows[indexRow].Cells[6].Value.ToString();
            }
        }

        private void btn_xoa_Khachhang_Click_1(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Xóa khách hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (rs == DialogResult.OK)
            {
                //Mode 3 = Delete data
                bool Resulte = ManageCustomer(txt_maKH.Text, txt_tenKH.Text, txt_sothue.Text,
                txt_diachi.Text, txt_thanhpho.Text, txt_dt.Text, txt_fax.Text, 3);
                if (Resulte == true)
                {
                    MessageBox.Show("Xóa khách hàng thành công");
                    showData();
                }
            }
            else
            {
                return;
            }
        }

        private void btn_dung_Click(object sender, EventArgs e)
        {
            btn_them_KhachHang.Tag = null;
            txt_maKH.Enabled = false;
            txt_tenKH.Enabled = false;
            txt_sothue.Enabled = false;
            txt_diachi.Enabled = false;
            txt_thanhpho.Enabled = false;
            txt_dt.Enabled = false;
            txt_fax.Enabled = false;

            btn_them_KhachHang.Text = "Thêm";
            btn_sua_KhachHang.Enabled = true;
            if (Mode == 1)
            {
                txt_maKH.Text = "";
                txt_tenKH.Text = "";
                txt_sothue.Text = "";
                txt_diachi.Text = "";
                txt_thanhpho.Text = "";
                txt_dt.Text = "";
                txt_fax.Text = "";
            }
        }
    }
}
