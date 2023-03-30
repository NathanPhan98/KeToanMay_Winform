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
    public partial class frmSearchKhachHang : Form
    {
        public Action Btn_Search_Press;
        public Action Btn_Previous_Press;
        public Action Btn_Next_Press;
        public string searchValue = "";
        public int countItems = 0;
        public int currentRow = 1;
        
        public frmSearchKhachHang()
        {
            InitializeComponent();
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            lblItem.Text = "";
            lblCount.Text = "";
            lblSlash.Text = "";
        }

        public void SearchCustomer(string infomation, int row)
        {

            if (AppEnv.Phieu == "tPhieuNhapHangHoa")
            {
                AppEnv.procedurePhieu = "p_TimKiemPhieuNhap";
            }
            else if (AppEnv.Phieu == "tPhieuXuatHangHoa")
            {
                AppEnv.procedurePhieu = "p_TimKiemPhieuXuat";
            }
            else if (AppEnv.Phieu == "tDanhMucKhachHang")
            {
                AppEnv.procedurePhieu = "p_TimKiemKhachHang";
            }



            OleDbCommand command = new OleDbCommand(AppEnv.procedurePhieu, AppEnv.WorkDB);

            command.Parameters.AddWithValue("@param", infomation);
            command.Parameters.AddWithValue("@rows", row);
            command.CommandType = CommandType.StoredProcedure;
            OleDbDataReader reader = command.ExecuteReader();
            //if (reader.Read() && AppEnv.Phieu == "tDanhMucKhachHang")
            //{
            //    searchValue = reader["cMaKhachHang"].ToString();
            //}
            if (reader.Read())
            {
                searchValue = reader["cMaChungTu"].ToString();
            }

        }

        public void CountSearchCustomer(string infomation)
        {
            if (AppEnv.Phieu == "tPhieuNhapHangHoa")
            {
                AppEnv.procedureSLPhieu = "p_SoLuongTimKiemPhieuNhap";
            }
            else if (AppEnv.Phieu == "tPhieuXuatHangHoa")
            {
                AppEnv.procedureSLPhieu = "p_SoLuongTimKiemPhieuXuat";
            }
            //else if (AppEnv.Phieu == "tDanhMucKhachHang")
            //{
            //    AppEnv.procedurePhieu = "p_SoLuongTimKiemKhachHang";
            //}
           
            

            OleDbCommand commannd = new OleDbCommand(AppEnv.procedureSLPhieu, AppEnv.WorkDB);

            commannd.Parameters.AddWithValue("@param", infomation);
            commannd.CommandType = CommandType.StoredProcedure;
            OleDbDataReader reader = commannd.ExecuteReader();
            if (reader.Read())
            {
                countItems = int.Parse(reader["items"].ToString());
            }

        }

        private void btn_search_khachhhang_Click(object sender, EventArgs e)
        {
            //Event catch btn_search in frmSearchKhachHang press
            SearchCustomer(txt_info_khachhang.Text , currentRow);
            CountSearchCustomer(txt_info_khachhang.Text);
            if (Btn_Search_Press != null) Btn_Search_Press();
            if(countItems > 0)
            {
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
                lblItem.Text = countItems.ToString();
                lblCount.Text = currentRow.ToString();
                lblSlash.Text = "/";
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
                
            if(currentRow <= 1)
            {
               currentRow = 1;
            }
            else
            {
                currentRow--;
            }
            lblCount.Text = currentRow.ToString();
            SearchCustomer(txt_info_khachhang.Text, currentRow);
                if (Btn_Previous_Press != null) Btn_Previous_Press();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            if (currentRow >= countItems)
            {
                currentRow = countItems;
            }
            else
            {
                currentRow++;
            }
            lblCount.Text = currentRow.ToString();
            SearchCustomer(txt_info_khachhang.Text, currentRow);
            if (Btn_Next_Press != null) Btn_Next_Press();

        }

        private void frmSearchKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
