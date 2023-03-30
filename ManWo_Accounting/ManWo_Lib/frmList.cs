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
using ManWo_Accounting;

namespace ManWo_Lib
{
    public partial class frmList : Form
    {
        private OleDbDataAdapter objAdapter;
        private DataSet ds;
        frmSearchKhachHang search = new frmSearchKhachHang();
        public frmList()
        {
            InitializeComponent();
        }

        private void frmList_Load(object sender, EventArgs e)
        {
            showData(AppEnv.loadMode);
        }

        private void showData(int loadMode)
        {
            ds = new DataSet();

            if (loadMode == 1)
            {
                string query = "select * from tDanhMucHangHoa";

                objAdapter = new OleDbDataAdapter(query, AppEnv.WorkDB);
            }
            else if (loadMode == 2)
            {
                string query = "select * from tPhieuNhapHangHoaChiTiet where cMaHang ='" + AppEnv.maHHfXH + "'";

                objAdapter = new OleDbDataAdapter(query, AppEnv.WorkDB);
            }
            else if (loadMode == 3)
            {
                string query = "select * from tDanhMucTaiKhoan where bCoDinhKhoan = 1";

                objAdapter = new OleDbDataAdapter(query, AppEnv.WorkDB);
            }
            else if (loadMode == 4)
            {
                string query = " select * from tdanhmuckhachhang";

                objAdapter = new OleDbDataAdapter(query, AppEnv.WorkDB);
            }

            objAdapter.Fill(ds, "danhMuc");
            dgvList.DataSource = ds.Tables["danhMuc"];
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AppEnv.loadMode == 1)
            {
                int indexRow = dgvList.CurrentCell.RowIndex;
                AppEnv.maHHfXH = dgvList.Rows[indexRow].Cells[0].Value.ToString();
                AppEnv.tenSPHHfXH = dgvList.Rows[indexRow].Cells[1].Value.ToString();
                AppEnv.dvtHHfXH = dgvList.Rows[indexRow].Cells[3].Value.ToString();

                float slTon = float.Parse(dgvList.Rows[indexRow].Cells[4].Value.ToString());
                float ttTon = float.Parse(dgvList.Rows[indexRow].Cells[5].Value.ToString());

                if (slTon == 0 || ttTon == 0)
                {
                    AppEnv.dgHHfXH = 0;
                }
                else
                {
                    AppEnv.dgHHfXH = ttTon / slTon;
                }
            }
            else if (AppEnv.loadMode == 2)
            {
                int indexRow = dgvList.CurrentCell.RowIndex;
                AppEnv.phieuNhapHHfXH = dgvList.Rows[indexRow].Cells[0].Value.ToString();
            }
            else if (AppEnv.loadMode == 3)
            {
                int indexRow = dgvList.CurrentCell.RowIndex;
                AppEnv.maPNTK = dgvList.Rows[indexRow].Cells[0].Value.ToString();
            }
            else if (AppEnv.loadMode == 4)
            {
                int indexRow = dgvList.CurrentCell.RowIndex;
                AppEnv.maKHNH = dgvList.Rows[indexRow].Cells[0].Value.ToString();
                AppEnv.tenKHNH = dgvList.Rows[indexRow].Cells[1].Value.ToString();
                AppEnv.mstKHNH = dgvList.Rows[indexRow].Cells[2].Value.ToString();
            }


            this.Close();
        }

        private void Btn_Search_Press()
        {
            if (AppEnv.Phieu == "tPhieuXuatHangHoa" || AppEnv.Phieu == "tPhieuNhapHangHoa")
            {
                var row = dgvList.Rows.Cast<DataGridViewRow>()
               .Where(x => !x.IsNewRow)
               .Where(x => ((DataRowView)x.DataBoundItem)["cMaChungTu"].ToString().Equals(search.searchValue))
               .FirstOrDefault();
                this.dgvList.CurrentCell = row.Cells[0];
            }
            //else if (AppEnv.Phieu == "tDanhMucKhachHang")
            //{
            //    var row = dgvList.Rows.Cast<DataGridViewRow>()
            //   .Where(x => !x.IsNewRow)
            //   .Where(x => ((DataRowView)x.DataBoundItem)["cMaKhachHang"].ToString().Equals(search.searchValue))
            //   .FirstOrDefault();
            //    this.dgvList.CurrentCell = row.Cells[0];
            //}
            
        }

        private void Search_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppEnv.FormOpen = false;
        }

        private void dgvList_KeyDown(object sender, KeyEventArgs e)
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
    }
}
