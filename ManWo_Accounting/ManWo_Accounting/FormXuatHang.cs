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
using System.Data.SqlClient;
using System.Globalization;

namespace ManWo_Accounting
{
    public partial class FormXuatHang : Form
    {
        private OleDbDataAdapter objAdapter;
        private DataSet ds;
        //private BindingSource bs; // để đổ data vào textbox
        private DataTable dt;
        int DataRow = 0;
        int Count = 0;

        private int Mode = 0;
        public FormXuatHang()
        {
            InitializeComponent();
        }

        private void FormXuatHang_Load(object sender, EventArgs e)
        {
            if (AppEnv.dTuNgay == DateTime.MinValue || AppEnv.dDenNgay == DateTime.MinValue)
            {
                frmTuNgayDenNgay Ngay = new frmTuNgayDenNgay();
                Ngay.ShowDialog();

                if (AppEnv.dTuNgay != DateTime.MinValue || AppEnv.dDenNgay != DateTime.MinValue)
                {
                    loadXuatHang(DataRow);
                    loadChiTietXuatHang();
                    if (dgvChiTietXuatHang.RowCount > 1)
                    {
                        loadTxtCT();
                    }
                    else
                    {
                        loadTxtCTNull();
                    }
                }
            }
            else
            {
                loadXuatHang(DataRow);
                loadChiTietXuatHang();
                if (dgvChiTietXuatHang.RowCount > 1)
                {
                    loadTxtCT();
                }
                else
                {
                    loadTxtCTNull();
                }
            }
        }

        private void loadXuatHang(int row)
        {

            string query = "set dateformat dmy select * from tPhieuXuatHangHoa where dNgayChungTu between '" + AppEnv.dTuNgay.Date.ToShortDateString() + "' and '" + AppEnv.dDenNgay.Date.ToShortDateString() + "' order by dNgayChungTu";
            objAdapter = new OleDbDataAdapter(query, AppEnv.WorkDB);

            dt = new DataTable();
            objAdapter.Fill(dt);

            txtMaChungTu.Text = dt.Rows[row]["cMaChungTu"].ToString();
            txtLoaiChungTu.Text = dt.Rows[row]["cLoaiChungTu"].ToString();
            txtNgayChungTu.Text = dt.Rows[row]["dNgayChungTu"].ToString();
            txtSoChungTu.Text = dt.Rows[row]["cSoChungTu"].ToString();
            txtSoSeRi.Text = dt.Rows[row]["cSoSeri"].ToString();
            txtSoHoaDon.Text = dt.Rows[row]["cSoHoaDon"].ToString();
            txtMatHang.Text = dt.Rows[row]["cMatHang"].ToString();
            txtMaKhachHang.Text = dt.Rows[row]["cMaKhachHang"].ToString();
            txtTenKhachHang.Text = dt.Rows[row]["cTenKhachHang"].ToString();
            txtMaSoThue.Text = dt.Rows[row]["cMaSoThue"].ToString();
            txtTaiKhoanNoGiaVon.Text = dt.Rows[row]["cTaiKhoanNoGiaVon"].ToString();
            txtTaiKhoanCoGiaVon.Text = dt.Rows[row]["cTaiKhoanCoGiaVon"].ToString();
            txtTaiKhoanNoGiaBan.Text = dt.Rows[row]["cTaiKhoanNoGiaBan"].ToString();
            txtTaiKhoanCoGiaBan.Text = dt.Rows[row]["cTaiKhoanCoGiaBan"].ToString();
            txtThueSuat.Text = dt.Rows[row]["nThueSuat"].ToString();
            txtThueGTGT.Text = dt.Rows[row]["nThueGTGT"].ToString();
            txtTaiKhoanCoGTGT.Text = dt.Rows[row]["cTaiKhoanCoGTGT"].ToString();
            txtDienGiai.Text = dt.Rows[row]["cDienGiai"].ToString();
        }

        private void loadChiTietXuatHang()
        {
            string query = "select * from tPhieuXuatHangHoaChiTiet where cMaChungTu='" + txtMaChungTu.Text + "' ";
            objAdapter = new OleDbDataAdapter(query, AppEnv.WorkDB);
            ds = new DataSet();
            objAdapter.Fill(ds, "tPhieuXuatHangHoaChiTiet");
            dgvChiTietXuatHang.DataSource = ds.Tables["tPhieuXuatHangHoaChiTiet"];

            dgvChiTietXuatHang.Columns[0].HeaderText = "Mã chứng từ";
            dgvChiTietXuatHang.Columns[1].HeaderText = "Mã hàng";
            dgvChiTietXuatHang.Columns[2].HeaderText = "Đơn vị tính";
            dgvChiTietXuatHang.Columns[3].HeaderText = "Số lượng ";
            dgvChiTietXuatHang.Columns[4].HeaderText = "Đơn giá vốn";
            dgvChiTietXuatHang.Columns[5].HeaderText = "Thành tiền giá vốn";
            dgvChiTietXuatHang.Columns[6].HeaderText = "Đơn giá vốn";
            dgvChiTietXuatHang.Columns[7].HeaderText = "Thành tiền giá vốn";
            dgvChiTietXuatHang.Columns[8].HeaderText = "Mã chứng từ nhập";

            

        }
        private void dgvChiTietXuatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadTxtCT();

            btnMuc.Enabled = false;
            btnDelete.Enabled = true;
            btnCancel.Enabled = true;

            btnNext.Enabled = false;
            btnLast.Enabled = false;
            btnPrevious.Enabled = false;
            btnFirst.Enabled = false;
        }
        private void loadTxtCT()
        {
            int indexRow = dgvChiTietXuatHang.CurrentCell.RowIndex;
            //maCTCT = dgvChiTietNhapHang.Rows[indexRow].Cells[0].Value.ToString();
            //maSo = dgvChiTietNhapHang.Rows[indexRow].Cells[1].Value.ToString();
            txtCTMaHang.Text = dgvChiTietXuatHang.Rows[indexRow].Cells[1].Value.ToString();
            txtCTDVT.Text = dgvChiTietXuatHang.Rows[indexRow].Cells[2].Value.ToString();
            txtCTSL.Text = dgvChiTietXuatHang.Rows[indexRow].Cells[3].Value.ToString();
            txtCTDonGiaVon.Text = dgvChiTietXuatHang.Rows[indexRow].Cells[4].Value.ToString();
            //txtCTGiaTTVon.Text = dgvChiTietXuatHang.Rows[indexRow].Cells[5].Value.ToString();
            txtCTDonGiaBan.Text = dgvChiTietXuatHang.Rows[indexRow].Cells[6].Value.ToString();
            //txtCTGiaTTBan.Text = dgvChiTietXuatHang.Rows[indexRow].Cells[7].Value.ToString();
            txtCTMaChungTuNhap.Text = dgvChiTietXuatHang.Rows[indexRow].Cells[8].Value.ToString();
        }
        private void loadTxtCTNull()
        {
            txtCTMaHang.Text = "";
            txtCTDVT.Text = "";
            txtCTSL.Text = "";
            txtCTDonGiaVon.Text = "";
            //txtCTGiaTTVon.Text = "";
            txtCTDonGiaBan.Text = "";
            //txtCTGiaTTBan.Text = "";
            txtCTMaChungTuNhap.Text = "";
        }
        // <Dieu huong>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            DataRow = 0;
            loadXuatHang(DataRow);
            loadChiTietXuatHang();
            if (dgvChiTietXuatHang.RowCount > 1)
            {
                loadTxtCT();
            }
            else
            {
                loadTxtCTNull();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (DataRow > 0)
                DataRow--;
            Count = DataRow;
            loadXuatHang(DataRow);
            loadChiTietXuatHang();
            if (dgvChiTietXuatHang.RowCount > 1)
            {
                loadTxtCT();
            }
            else
            {
                loadTxtCTNull();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (DataRow < dt.Rows.Count - 1)
                DataRow++;
            Count = DataRow;
            loadXuatHang(DataRow);
            loadChiTietXuatHang();
            if (dgvChiTietXuatHang.RowCount > 1)
            {
                loadTxtCT();
            }
            else
            {
                loadTxtCTNull();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            DataRow = dt.Rows.Count - 1;
            loadXuatHang(DataRow);
            loadChiTietXuatHang();
            if (dgvChiTietXuatHang.RowCount > 1)
            {
                loadTxtCT();
            }
            else
            {
                loadTxtCTNull();
            }
        }
        // </Dieu huong>

        private void btnMuc_Click(object sender, EventArgs e)
        {
            Mode = 4;
            if (btnMuc.Tag == null)
            {
                btnPhieu.Tag = "toogled";

                txtCTMaHang.Text = "";
                txtCTMaChungTuNhap.Text = "";
                txtCTDonGiaVon.Text = "";
                txtCTDonGiaBan.Text = "0";
                txtCTSL.Text = "0";
                txtCTDVT.Text = "";
                //txtCTGiaTTVon.Text = "0";
                //txtCTGiaTTBan.Text = "0";

                btnPhieu.Text = "GHI";

                txtCTMaHang.Enabled = true;
                txtCTMaChungTuNhap.Enabled = true;
                //txtCTDonGiaVon.Enabled = true;
                txtCTDonGiaBan.Enabled = true;
                txtCTSL.Enabled = true;
                txtCTDVT.Enabled = true;
                //txtCTGiaTTVon.Enabled = true;
                //txtCTGiaTTBan.Enabled = true;

                btnSearch.Enabled = false;
                btnCancel.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnSQL.Enabled = false;

                btnNext.Enabled = false;
                btnLast.Enabled = false;
                btnPrevious.Enabled = false;
                btnFirst.Enabled = false;

                dgvChiTietXuatHang.Enabled = false;
            }
        }

        private void btnPhieu_Click(object sender, EventArgs e)
        {
            if (btnPhieu.Tag == null)
            {
                //Mode 1 = Insert data
                Mode = 1;

                btnPhieu.Tag = "toogled";
                DataRow = dt.Rows.Count;
                txtMaChungTu.Text = "";
                txtLoaiChungTu.Text = "";
                txtDienGiai.Text = "";
                txtMaKhachHang.Text = "";
                txtMaSoThue.Text = "";
                txtTenKhachHang.Text = "";
                txtMatHang.Text = "";
                txtNgayChungTu.Text = "";
                txtSoChungTu.Text = "";
                txtSoHoaDon.Text = "";
                txtSoSeRi.Text = "";
                txtTaiKhoanCoGiaBan.Text = "";
                txtTaiKhoanNoGiaBan.Text = "";
                txtTaiKhoanCoGiaVon.Text = "";
                txtTaiKhoanNoGiaVon.Text = "";
                txtTaiKhoanCoGTGT.Text = "";
                txtThueGTGT.Text = "";
                txtThueSuat.Text = "";

                txtCTMaChungTuNhap.Text = "";
                txtCTMaHang.Text = "";
                txtCTDonGiaBan.Text = "0";
                txtCTSL.Text = "0";
                //txtCTGiaTTBan.Text = "0";
                txtCTDonGiaVon.Text = "0";
                //txtCTGiaTTBan.Text = "0";

                btnPhieu.Text = "GHI";

                txtLoaiChungTu.Enabled = true;
                txtNgayChungTu.Enabled = true;
                txtSoChungTu.Enabled = true;
                txtSoSeRi.Enabled = true;
                txtSoHoaDon.Enabled = true;
                txtMatHang.Enabled = true;
                txtMaKhachHang.Enabled = true;
                txtTaiKhoanNoGiaVon.Enabled = true;
                txtTaiKhoanNoGiaBan.Enabled = true;
                txtTaiKhoanCoGiaVon.Enabled = true;
                txtTaiKhoanCoGiaBan.Enabled = true;
                txtTaiKhoanCoGTGT.Enabled = true;
                txtThueSuat.Enabled = true;
                txtThueGTGT.Enabled = true;
                txtDienGiai.Enabled = true;
               
                

                txtCTMaHang.Enabled = true;
                txtCTDonGiaBan.Enabled = true;
                txtCTSL.Enabled = true;
                txtCTDVT.Enabled = true;
                //txtCTGiaTTBan.Enabled = true;
                btnCancel.Enabled = true;

                btnSQL.Enabled = false;
                btnSearch.Enabled = false;
                btnMuc.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                dgvChiTietXuatHang.DataSource = null;

                btnNext.Enabled = false;
                btnLast.Enabled = false;
                btnPrevious.Enabled = false;
                btnFirst.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(txtCTMaHang, "");
                if (txtCTMaHang.Text == "")
                {
                    errorProvider1.SetError(txtCTMaHang, "Trường này không được trống");
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }

                if (Mode == 1)
                {
                    string machungtuauto = txtLoaiChungTu.Text + "-" + txtSoChungTu.Text + "-" + DateTime.Parse(txtNgayChungTu.Text).ToString("dd/MM/yy");
                    txtMaChungTu.Text = machungtuauto;

                    float GiaTTBan = float.Parse(txtCTSL.Text) * float.Parse(txtCTDonGiaBan.Text);
                    //txtCTGiaTTVon.Text = GiaTTBan.ToString();

                    float GiaTTVon = float.Parse(txtCTSL.Text) * float.Parse(txtCTDonGiaVon.Text);
                    //txtCTGiaTTVon.Text = GiaTTVon.ToString();

                    if (txtCTMaHang.Text != "" && txtMaChungTu.Text != "")
                    {
                        bool Result = QuanLyNhapXuat.ManageXuatHang(txtMaChungTu.Text, txtLoaiChungTu.Text, Convert.ToDateTime(txtNgayChungTu.Text), txtSoChungTu.Text,
                                               txtMaKhachHang.Text, txtTenKhachHang.Text, txtMaSoThue.Text,
                                                 txtTaiKhoanNoGiaVon.Text, txtTaiKhoanCoGiaVon.Text, txtTaiKhoanNoGiaBan.Text, txtTaiKhoanCoGiaBan.Text, txtTaiKhoanCoGTGT.Text,
                                                txtDienGiai.Text, txtMatHang.Text, txtThueSuat.Text, txtThueGTGT.Text, txtSoSeRi.Text, txtSoHoaDon.Text, Mode);
                        Mode = 4;
                        bool result_ct = QuanLyNhapXuat.manageCTXuatHang(txtMaChungTu.Text, txtCTMaHang.Text, txtCTDVT.Text, float.Parse(txtCTSL.Text),
                                                            float.Parse(txtCTDonGiaVon.Text), GiaTTVon, float.Parse(txtCTDonGiaBan.Text),
                                                            GiaTTBan, txtCTMaChungTuNhap.Text, Mode);
                        if (Result && result_ct)
                        {
                            MessageBox.Show("Thêm thành công ");
                            DataRow = dt.Rows.Count;
                            loadXuatHang(DataRow);
                            loadChiTietXuatHang();


                            defaultBtn();
                        }
                    }


                }
                else if (Mode == 2)
                {
                    //Mode 2 = Update data
                    bool Result = QuanLyNhapXuat.ManageXuatHang(txtMaChungTu.Text, txtLoaiChungTu.Text, Convert.ToDateTime(txtNgayChungTu.Text), txtSoChungTu.Text,
                                               txtMaKhachHang.Text, txtTenKhachHang.Text, txtMaSoThue.Text,
                                                 txtTaiKhoanNoGiaVon.Text, txtTaiKhoanCoGiaVon.Text, txtTaiKhoanNoGiaBan.Text, txtTaiKhoanCoGiaBan.Text, txtTaiKhoanCoGTGT.Text,
                                                txtDienGiai.Text, txtMatHang.Text, txtThueSuat.Text, txtThueGTGT.Text, txtSoSeRi.Text, txtSoHoaDon.Text, Mode);


                    float GiaTTBan = float.Parse(txtCTSL.Text) * float.Parse(txtCTDonGiaBan.Text);
                    //txtCTGiaTTVon.Text = GiaTTBan.ToString();

                    float GiaTTVon = float.Parse(txtCTSL.Text) * float.Parse(txtCTDonGiaVon.Text);
                    //txtCTGiaTTVon.Text = GiaTTVon.ToString();


                    bool result_ct = QuanLyNhapXuat.manageCTXuatHang(txtMaChungTu.Text, txtCTMaHang.Text, txtCTDVT.Text, float.Parse(txtCTSL.Text), float.Parse(txtCTDonGiaVon.Text),
                                        GiaTTVon, float.Parse(txtCTDonGiaBan.Text), GiaTTBan, txtCTMaChungTuNhap.Text , Mode);
                    if (Result && result_ct)
                    {
                        MessageBox.Show("Sửa thành công ");
                    }
                    txtCTMaHang.Enabled = true;
                    txtCTDonGiaBan.Enabled = true;
                    txtCTDonGiaVon.Enabled = true;
                    txtCTSL.Enabled = true;
                    txtCTDVT.Enabled = true;
                    //txtCTGiaTTVon.Enabled = true;
                    //txtCTGiaTTBan.Enabled = true;
                    defaultBtn();

                    
                    loadXuatHang(DataRow);
                    loadChiTietXuatHang();
                }
                else if (Mode == 4)
                {
                    //Mode 4 = Insert detail product

                    float GiaTTBan = float.Parse(txtCTSL.Text) * float.Parse(txtCTDonGiaBan.Text);
                    //txtCTGiaTTVon.Text = GiaTTBan.ToString();

                    float GiaTTVon = float.Parse(txtCTSL.Text) * float.Parse(txtCTDonGiaVon.Text);
                    //txtCTGiaTTVon.Text = GiaTTVon.ToString();

                    bool result_ct = QuanLyNhapXuat.manageCTXuatHang(txtMaChungTu.Text, txtCTMaHang.Text, txtCTDVT.Text, float.Parse(txtCTSL.Text), 
                        float.Parse(txtCTDonGiaVon.Text), GiaTTVon, float.Parse(txtCTDonGiaBan.Text), GiaTTBan, txtCTMaChungTuNhap.Text, Mode); 
                    if (result_ct)
                    {
                        MessageBox.Show("Thêm chi tiết hàng hóa thành công");
                    }
                    loadChiTietXuatHang();
                    btnMuc.Tag = null;
                    defaultBtn();

                }

                btnPhieu.Tag = null;
                btnPhieu.Text = "Phiếu";

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Mode 2 = Update data
            Mode = 2;
            if (btnUpdate.Tag == null)
            {
                btnPhieu.Tag = "toogled";
                btnPhieu.Text = "GHI";

                txtSoSeRi.Enabled = true;
                txtSoHoaDon.Enabled = true;
                txtMatHang.Enabled = true;
                txtMaKhachHang.Enabled = true;
                txtTaiKhoanNoGiaVon.Enabled = true;
                txtTaiKhoanNoGiaBan.Enabled = true;
                txtTaiKhoanCoGiaVon.Enabled = true;
                txtTaiKhoanCoGiaBan.Enabled = true;
                txtTaiKhoanCoGTGT.Enabled = true;
                txtThueSuat.Enabled = true;
                txtThueGTGT.Enabled = true;
                txtDienGiai.Enabled = true;

                txtCTMaHang.Enabled = false;
                txtCTMaChungTuNhap.Enabled = false;
                txtCTDVT.Enabled = false;
                txtCTDonGiaVon.Enabled = false;

                txtCTSL.Enabled = true;
                txtCTDonGiaBan.Enabled = true;

               
                btnCancel.Enabled = true;
                btnMuc.Enabled = false;
                btnDelete.Enabled = false;
                btnSearch.Enabled = false;
                btnSQL.Enabled = false;

                btnNext.Enabled = false;
                btnLast.Enabled = false;
                btnPrevious.Enabled = false;
                btnFirst.Enabled = false;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Xóa chi tiết hàng hóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            int currentItem = DataRow;
            if (rs == DialogResult.OK)
            {
                //Mode 3 = Delete data
                Mode = 3;
                bool result_ct;
                int countItems = dgvChiTietXuatHang.RowCount - 1;

                float GiaTTBan = float.Parse(txtCTSL.Text) * float.Parse(txtCTDonGiaBan.Text);
                float GiaTTVon = float.Parse(txtCTSL.Text) * float.Parse(txtCTDonGiaVon.Text);


                if (countItems > 1)
                {
                    result_ct = QuanLyNhapXuat.manageCTXuatHang(txtMaChungTu.Text, txtCTMaHang.Text, txtCTDVT.Text, float.Parse(txtCTSL.Text),
                        float.Parse(txtCTDonGiaVon.Text), GiaTTVon, float.Parse(txtCTDonGiaBan.Text), GiaTTBan, txtCTMaChungTuNhap.Text, Mode);
                    loadChiTietXuatHang();
                    loadTxtCT();
                    if (result_ct)
                    {
                        MessageBox.Show("Xóa hàng hóa thành công");
                    }
                }

                if (countItems == 1)
                {
                    bool result = QuanLyNhapXuat.ManageXuatHang(txtMaChungTu.Text, txtLoaiChungTu.Text, Convert.ToDateTime(txtNgayChungTu.Text), txtSoChungTu.Text,
                                               txtMaKhachHang.Text, txtTenKhachHang.Text, txtMaSoThue.Text,
                                                 txtTaiKhoanNoGiaVon.Text, txtTaiKhoanCoGiaVon.Text, txtTaiKhoanNoGiaBan.Text, txtTaiKhoanCoGiaBan.Text, txtTaiKhoanCoGTGT.Text,
                                                txtDienGiai.Text, txtMatHang.Text, txtThueSuat.Text, txtThueGTGT.Text, txtSoSeRi.Text, txtSoHoaDon.Text, Mode);

                    MessageBox.Show("Hóa đơn đã được xóa!");
                    DataRow = 0;
                    loadXuatHang(DataRow);
                    defaultBtn();
                }
                //loadChiTietXuatHang();
                
            }
            else
            {
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormListPhieu frm = new FormListPhieu();
            AppEnv.Phieu = "tPhieuXuatHangHoa";
            frm.ShowDialog();

            loadXuatHang(AppEnv.maCTXHSearch);
            loadChiTietXuatHang();
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            frmTuNgayDenNgay objfrm = new frmTuNgayDenNgay();
            objfrm.ShowDialog();
            DataRow = 0;
            loadXuatHang(0);
            loadChiTietXuatHang();
            defaultBtn();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            defaultBtn();
            defaultRow();
        }

        void defaultBtn()
        {
            errorProvider1.SetError(txtCTMaHang, "");

            btnMuc.Tag = null;
            btnPhieu.Tag = null;
            btnPhieu.Text = "Phiếu";
            btnSearch.Enabled = true;
            btnUpdate.Enabled = true;
            btnMuc.Enabled = true;
            btnSQL.Enabled = true;

            btnCancel.Enabled = false;
            btnDelete.Enabled = false;

            btnNext.Enabled = true;
            btnLast.Enabled = true;
            btnPrevious.Enabled = true;
            btnFirst.Enabled = true;

            txtLoaiChungTu.Enabled = false;
            txtNgayChungTu.Enabled = false;
            txtSoChungTu.Enabled = false;
            txtSoSeRi.Enabled = false;
            txtSoHoaDon.Enabled = false;
            txtMatHang.Enabled = false;
            txtMaKhachHang.Enabled = false;
            txtTaiKhoanNoGiaVon.Enabled = false;
            txtTaiKhoanNoGiaBan.Enabled = false;
            txtTaiKhoanCoGiaVon.Enabled = false;
            txtTaiKhoanCoGiaBan.Enabled = false;
            txtTaiKhoanCoGTGT.Enabled = false;
            txtThueSuat.Enabled = false;
            txtThueGTGT.Enabled = false;
            txtDienGiai.Enabled = false;

            txtCTMaHang.Enabled = false;
            txtCTMaChungTuNhap.Enabled = false;
            txtCTDonGiaVon.Enabled = false;
            txtCTDonGiaBan.Enabled = false;
            txtCTSL.Enabled = false;
            txtCTDVT.Enabled = false;

            dgvChiTietXuatHang.Enabled = true;
        }

        void defaultRow()
        {
            DataRow = Count;
            loadXuatHang(DataRow);
            loadChiTietXuatHang();
            loadTxtCT();
        }
        private void txtCTMaHang_Click(object sender, EventArgs e)
        {
            AppEnv.loadMode = 1;
            frmList frm = new frmList();
            frm.ShowDialog();

            txtCTMaHang.Text = AppEnv.maHHfXH;
            txtCTDVT.Text = AppEnv.dvtHHfXH;
            txtCTDonGiaVon.Text = AppEnv.dgHHfXH.ToString();

            if (txtCTMaHang.Text != "")
            {
                txtCTMaChungTuNhap.Enabled = true;
            }
        }

        private void txtCTMaChungTuNhap_Click(object sender, EventArgs e)
        {
            AppEnv.loadMode = 2;
            frmList frm = new frmList();
            frm.ShowDialog();

            txtCTMaChungTuNhap.Text = AppEnv.phieuNhapHHfXH;
        }

        private void txtTaiKhoanNoGiaVon_Click(object sender, EventArgs e)
        {
            AppEnv.loadMode = 3;
            frmList objfrm = new frmList();
            objfrm.ShowDialog();

            txtTaiKhoanNoGiaVon.Text = AppEnv.maPNTK;
        }

        private void txtTaiKhoanCoGiaVon_Click(object sender, EventArgs e)
        {
            AppEnv.loadMode = 3;
            frmList objfrm = new frmList();
            objfrm.ShowDialog();

            txtTaiKhoanCoGiaVon.Text = AppEnv.maPNTK;
        }

        private void txtTaiKhoanNoGiaBan_Click(object sender, EventArgs e)
        {
            AppEnv.loadMode = 3;
            frmList objfrm = new frmList();
            objfrm.ShowDialog();

            txtTaiKhoanNoGiaBan.Text = AppEnv.maPNTK;
        }

        private void txtTaiKhoanCoGiaBan_Click(object sender, EventArgs e)
        {
            AppEnv.loadMode = 3;
            frmList objfrm = new frmList();
            objfrm.ShowDialog();

            txtTaiKhoanCoGiaBan.Text = AppEnv.maPNTK;
        }

        private void txtTaiKhoanCoGTGT_Click(object sender, EventArgs e)
        {
            AppEnv.loadMode = 3;
            frmList objfrm = new frmList();
            objfrm.ShowDialog();

            txtTaiKhoanCoGTGT.Text = AppEnv.maPNTK;
        }

        private void txtMaKhachHang_Click(object sender, EventArgs e)
        {
            AppEnv.loadMode = 4;
            frmList objfrm = new frmList();
            objfrm.ShowDialog();

            txtMaKhachHang.Text = AppEnv.maKHNH;
            txtTenKhachHang.Text = AppEnv.tenKHNH;
            txtMaSoThue.Text = AppEnv.mstKHNH;
        }
    }
}
