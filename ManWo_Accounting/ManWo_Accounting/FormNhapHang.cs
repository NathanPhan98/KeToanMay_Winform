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
    public delegate void choice(string value1,string value2,string value3);
    public partial class FormNhapHang : Form
    {
        private OleDbDataAdapter objAdapter;
        private DataSet ds;
        //private BindingSource bs; // để đổ data vào textbox
        private DataTable dt;
        int DataRow = 0;
        int Count = 0;

        private int Mode = 0;
        public FormNhapHang()
        {
            InitializeComponent();
        }

        int maPNTK1;
        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            if( AppEnv.dTuNgay == DateTime.MinValue || AppEnv.dDenNgay == DateTime.MinValue)
            {
                frmTuNgayDenNgay Ngay = new frmTuNgayDenNgay();
                Ngay.ShowDialog();

                if (AppEnv.dTuNgay != DateTime.MinValue || AppEnv.dDenNgay != DateTime.MinValue)
                {
                    loadNhapHang(DataRow);
                    loadChiTietNhapHang();
                    
                    if (dgvChiTietNhapHang.RowCount > 1)
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
                loadNhapHang(DataRow);
                loadChiTietNhapHang();
                
                if (dgvChiTietNhapHang.RowCount > 1)
                {
                    loadTxtCT();
                }
                else
                {
                    loadTxtCTNull();
                }
            }
            
        }


        private void loadNhapHang(int row)
        {

            string query = "set dateformat dmy select * from tPhieuNhapHangHoa where dNgayChungTu between '" + AppEnv.dTuNgay.Date.ToShortDateString() + "' and '"+ AppEnv.dDenNgay.Date.ToShortDateString() + "' order by dNgayChungTu";
            objAdapter = new OleDbDataAdapter(query, AppEnv.WorkDB);
          
            dt = new DataTable();
            objAdapter.Fill(dt);
            txtMaChungTu.Text = dt.Rows[row]["cMaChungTu"].ToString();
            txtLoaiChungTu.Text = dt.Rows[row]["cLoaiChungTu"].ToString();
            txtDienGiai.Text = dt.Rows[row]["cDienGiai"].ToString();
            txtMaNguoiBan.Text = dt.Rows[row]["cMaNguoiBan"].ToString();
            txtMaSoThueNguoiBan.Text = dt.Rows[row]["cMaSoThueNguoiBan"].ToString();
            txtMatHang.Text = dt.Rows[row]["cMatHang"].ToString();
            txtNgayChungTu.Text = dt.Rows[row]["dNgayChungTu"].ToString();
            txtNgayHoaDon.Text = dt.Rows[row]["dNgayHoaDon"].ToString();
            txtSoChungTu.Text = dt.Rows[row]["cSoChungTu"].ToString();
            txtSoHoaDon.Text = dt.Rows[row]["cSoHoaDon"].ToString();
            txtSoSeRi.Text = dt.Rows[row]["cSoSeRi"].ToString();
            txtTaiKhoanCo.Text = dt.Rows[row]["cTaiKhoanCo"].ToString();
            txtTaiKhoanNo.Text = dt.Rows[row]["cTaiKhoanNo"].ToString();
            txtTaiKhoanNoGTGT.Text = dt.Rows[row]["cTaiKhoanNoGTGT"].ToString();
            txtTenNguoiBan.Text = dt.Rows[row]["cTenNguoiBan"].ToString();
            txtThueGTGT.Text = dt.Rows[row]["nThueGTGT"].ToString();
            txtThueSuat.Text = dt.Rows[row]["nThueSuat"].ToString();
        }
        private void loadChiTietNhapHang()
        {
            //string query = "select * from tPhieuNhapHangHoaChiTiet where cMaChungTu='" +txtMaChungTu.Text + "'";
            string query = "select cMaChungTu, nMaSo, pnct.cMaHang, cTenHang, pnct.cDonViTinh, nSoLuong, nDonGia, nThanhTien " +
                "from tPhieuNhapHangHoaChiTiet pnct,tDanhMucHangHoa dmhh where pnct.cMaHang = dmhh.cMaHang" +
                " and cMaChungTu ='" + txtMaChungTu.Text + "'";
            objAdapter = new OleDbDataAdapter(query, AppEnv.WorkDB);
            ds = new DataSet();
            objAdapter.Fill(ds, "tPhieuNhapHangHoaChiTiet");
            dgvChiTietNhapHang.DataSource = ds.Tables["tPhieuNhapHangHoaChiTiet"];

            dgvChiTietNhapHang.Columns[0].HeaderText = "Mã chứng từ";
            dgvChiTietNhapHang.Columns[1].HeaderText = "Mã số";
            dgvChiTietNhapHang.Columns[2].HeaderText = "Mã hàng";
            dgvChiTietNhapHang.Columns[3].HeaderText = "Tên hàng";
            dgvChiTietNhapHang.Columns[4].HeaderText = "Đơn vị tính";
            dgvChiTietNhapHang.Columns[5].HeaderText = "Số lượng ";
            dgvChiTietNhapHang.Columns[6].HeaderText = "Đơn giá";
            dgvChiTietNhapHang.Columns[7].HeaderText = "Thành tiền";
        }

        //private void loadTenSP()
        //{
        //    string query = "select cTenHang from tPhieuNhapHangHoaChiTiet pnct,tDanhMucHangHoa dmhh " +
        //        " where pnct.cMaHang = dmhh.cMaHang and pnct.cMaHang='" + txtCTMaHang.Text + "'";
        //    objAdapter = new OleDbDataAdapter(query, AppEnv.WorkDB);
        //    ds = new DataSet();
        //    objAdapter.Fill(ds);
        //    txtCTTenHang.Text = ds.ToString();
        //}
        private void dgvChiTietNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
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
            int indexRow = dgvChiTietNhapHang.CurrentCell.RowIndex;
            //maCTCT = dgvChiTietNhapHang.Rows[indexRow].Cells[0].Value.ToString();
            //maSo = dgvChiTietNhapHang.Rows[indexRow].Cells[1].Value.ToString();
            txtCTMaHang.Text = dgvChiTietNhapHang.Rows[indexRow].Cells[2].Value.ToString();
            txtCTTenHang.Text = dgvChiTietNhapHang.Rows[indexRow].Cells[3].Value.ToString();
            txtCTDVT.Text = dgvChiTietNhapHang.Rows[indexRow].Cells[4].Value.ToString();
            txtCTSL.Text = dgvChiTietNhapHang.Rows[indexRow].Cells[5].Value.ToString();
            txtCTDonGia.Text = dgvChiTietNhapHang.Rows[indexRow].Cells[6].Value.ToString();
            txtCTThanhTien.Text = dgvChiTietNhapHang.Rows[indexRow].Cells[7].Value.ToString();
            
        }

        private void loadTxtCTNull()
        {
            txtCTMaHang.Text = "";
            txtCTDVT.Text = "";
            txtCTSL.Text = "";
            txtCTDonGia.Text = "";
            txtCTThanhTien.Text = "";
        }
        // <Dieu huong>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            DataRow = 0;
            loadNhapHang(DataRow);
            loadChiTietNhapHang();
            
            if (dgvChiTietNhapHang.RowCount > 1)
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
            loadNhapHang(DataRow);
            loadChiTietNhapHang();
            if (dgvChiTietNhapHang.RowCount > 1)
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
            loadNhapHang(DataRow);
            loadChiTietNhapHang();
            if (dgvChiTietNhapHang.RowCount > 1)
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
            loadNhapHang(DataRow);
            loadChiTietNhapHang();
            if (dgvChiTietNhapHang.RowCount > 1)
            {
                loadTxtCT();
            }
            else
            {
                loadTxtCTNull();
            }
        }
        // </Dieu huong>

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
                txtMaNguoiBan.Text = "";
                txtMaSoThueNguoiBan.Text = "";
                txtTenNguoiBan.Text = "";
                txtMatHang.Text = "";
                txtNgayChungTu.Text = "";
                txtNgayHoaDon.Text = "";
                txtSoChungTu.Text = "";
                txtSoHoaDon.Text = "";
                txtSoSeRi.Text = "";
                txtTaiKhoanCo.Text = "";
                txtTaiKhoanNo.Text = "";
                txtTaiKhoanNoGTGT.Text = "";
                txtThueGTGT.Text = "";
                txtThueSuat.Text = "";

                txtMaNguoiBan.Enabled = true; 

                txtCTMaHang.Text = "";
                txtCTDonGia.Text = "0";
                txtCTSL.Text = "0";
                txtCTThanhTien.Text = "0";

                btnPhieu.Text = "GHI";
                txtLoaiChungTu.Enabled = true;
                txtNgayChungTu.Enabled = true;
                txtSoChungTu.Enabled = true;
                txtNgayHoaDon.Enabled = true;

                txtSoSeRi.Enabled = true;
                txtSoHoaDon.Enabled = true;
                txtMatHang.Enabled = true;
                txtTenNguoiBan.Enabled = true;
                txtTaiKhoanNo.Enabled = true;
                txtTaiKhoanCo.Enabled = true;
                txtTaiKhoanNoGTGT.Enabled = true;
                txtThueSuat.Enabled = true;
                txtThueGTGT.Enabled = true;

                txtCTMaHang.Enabled = true;
                txtCTSL.Enabled = true;
                txtDienGiai.Enabled = true;

                btnCancel.Enabled = true;
                dgvChiTietNhapHang.DataSource = null;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
                btnPrevious.Enabled = false;
                btnFirst.Enabled = false;


                btnMuc.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnSearch.Enabled = false;
                btnSQL.Enabled = false;

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
                    string machungtuauto;
                    machungtuauto = txtLoaiChungTu.Text + "-" + txtSoChungTu.Text + "-" + DateTime.Parse(txtNgayChungTu.Text).ToString("dd/MM/yy");
                    txtMaChungTu.Text = machungtuauto;


                    float tinhtien = float.Parse(txtCTSL.Text) * float.Parse(txtCTDonGia.Text);
                    txtCTThanhTien.Text = tinhtien.ToString();

                    if (txtCTMaHang.Text != "" && txtMaChungTu.Text != "")
                    {
                        bool Result = QuanLyNhapXuat.ManageNhapHang(txtMaChungTu.Text, txtLoaiChungTu.Text, Convert.ToDateTime(txtNgayChungTu.Text), txtSoChungTu.Text,
                                               txtMaNguoiBan.Text, txtTenNguoiBan.Text, txtMaSoThueNguoiBan.Text,
                                               txtTaiKhoanNo.Text, txtTaiKhoanNoGTGT.Text, txtTaiKhoanCo.Text, txtDienGiai.Text,
                                               txtSoSeRi.Text, txtSoHoaDon.Text, Convert.ToDateTime(txtNgayHoaDon.Text), txtThueSuat.Text,
                                               txtThueGTGT.Text, txtMatHang.Text, Mode);
                        Mode = 4;
                        bool result_ct = QuanLyNhapXuat.manageCTNhapHang(txtMaChungTu.Text, txtCTMaHang.Text, txtCTDVT.Text, float.Parse(txtCTSL.Text), float.Parse(txtCTDonGia.Text),float.Parse(txtCTThanhTien.Text),0,Mode);
                        if (Result && result_ct)
                        {
                            MessageBox.Show("Thêm thành công ");
                            DataRow = dt.Rows.Count; 
                            loadNhapHang(DataRow);
                            loadChiTietNhapHang();

                            //btnMuc.Enabled = true;
                            //btnCancel.Enabled = false;
                            //btnDelete.Enabled = false;
                            //btnNext.Enabled = true;
                            //btnLast.Enabled = true;
                            //btnPrevious.Enabled = true;
                            //btnFirst.Enabled = true;
                            defaultBtn();
                        }
                    }
                    
                    
                }
                else if (Mode == 2)
                {
                    //Mode 2 = Update data
                    bool Result = QuanLyNhapXuat.ManageNhapHang(txtMaChungTu.Text, txtLoaiChungTu.Text, Convert.ToDateTime(txtNgayChungTu.Text), txtSoChungTu.Text,
                                                txtMaNguoiBan.Text, txtTenNguoiBan.Text, txtMaSoThueNguoiBan.Text,
                                                txtTaiKhoanNo.Text, txtTaiKhoanNoGTGT.Text, txtTaiKhoanCo.Text, txtDienGiai.Text,
                                                txtSoSeRi.Text, txtSoHoaDon.Text, Convert.ToDateTime(txtNgayHoaDon.Text), txtThueSuat.Text,
                                                txtThueGTGT.Text, txtMatHang.Text, Mode);

                    int indexRow = dgvChiTietNhapHang.CurrentCell.RowIndex;
                    int maSo = int.Parse(dgvChiTietNhapHang.Rows[indexRow].Cells[1].Value.ToString());
                    
                    float tinhtien = float.Parse(txtCTSL.Text) * float.Parse(txtCTDonGia.Text);
                    txtCTThanhTien.Text = tinhtien.ToString();
                    
                    bool result_ct = QuanLyNhapXuat.manageCTNhapHang(txtMaChungTu.Text, txtCTMaHang.Text, txtCTDVT.Text, float.Parse(txtCTSL.Text), float.Parse(txtCTDonGia.Text), float.Parse(txtCTThanhTien.Text), maSo, Mode);
                    if (Result && result_ct)
                    {
                        MessageBox.Show("Sửa thành công ");
                    }

                    //btnNext.Enabled = true;
                    //btnLast.Enabled = true;
                    //btnPrevious.Enabled = true;
                    //btnFirst.Enabled = true;

                    defaultBtn();
                    //btnDelete.Enabled = false;
                    //btnCancel.Enabled = false;
                    //txtCTMaHang.Enabled = true;
                    //txtCTSL.Enabled = true;
                    //btnMuc.Enabled = true;

                    loadNhapHang(DataRow);
                    loadChiTietNhapHang();
                }
                else if (Mode == 4)
                {
                    //Mode 4 = Insert detail product
                    float tinhtien = float.Parse(txtCTSL.Text) * float.Parse(txtCTDonGia.Text);
                    txtCTThanhTien.Text = tinhtien.ToString();

                    bool result_ct = QuanLyNhapXuat.manageCTNhapHang(txtMaChungTu.Text, txtCTMaHang.Text, txtCTDVT.Text, float.Parse(txtCTSL.Text), float.Parse(txtCTDonGia.Text), float.Parse(txtCTThanhTien.Text), 0,Mode);
                    if (result_ct)
                    {
                        MessageBox.Show("Thêm chi tiết hàng hóa thành công");
                    }
                    loadChiTietNhapHang();
                    btnMuc.Tag = null;
                    btnCancel.Enabled = false;

                    btnUpdate.Enabled = true;

                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                    btnPrevious.Enabled = true;
                    btnFirst.Enabled = true;

                    txtCTMaHang.Enabled = false;
                    txtCTSL.Enabled = false;
                    dgvChiTietNhapHang.Enabled = true;
                    defaultBtn();
                }

                btnPhieu.Tag = null;
                btnPhieu.Text = "Phiếu";
                
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormListPhieu frm = new FormListPhieu();
            AppEnv.Phieu = "tPhieuNhapHangHoa";
            frm.ShowDialog();

            loadNhapHang(AppEnv.maCTXHSearch);
            loadChiTietNhapHang();

            btnDelete.Enabled = false;
            btnMuc.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Mode 2 = Update data
            Mode = 2;
            if (btnUpdate.Tag == null)
            {
                btnPhieu.Tag = "toogled";
                btnPhieu.Text = "GHI";
                txtCTMaHang.Enabled = true;
                txtCTSL.Enabled = true;
                btnCancel.Enabled = true;
                txtMaNguoiBan.Enabled = true;
                txtTaiKhoanNo.Enabled = true;
                txtTaiKhoanCo.Enabled = true;
                txtTaiKhoanNoGTGT.Enabled = true;
                txtThueSuat.Enabled = true;
                txtThueGTGT.Enabled = true;
                txtMaSoThueNguoiBan.Enabled = true;
                txtDienGiai.Enabled = true;

                btnMuc.Enabled = false;
                btnSQL.Enabled = false;
                btnSearch.Enabled = false;
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
                int indexRow = dgvChiTietNhapHang.CurrentCell.RowIndex;
                int maSo = int.Parse(dgvChiTietNhapHang.Rows[indexRow].Cells[1].Value.ToString());

                int countItems = dgvChiTietNhapHang.RowCount - 1;
                if (countItems > 1)
                {
                    bool result_ct = QuanLyNhapXuat.manageCTNhapHang(txtMaChungTu.Text, txtCTMaHang.Text, txtCTDVT.Text, float.Parse(txtCTSL.Text), float.Parse(txtCTDonGia.Text), float.Parse(txtCTThanhTien.Text), maSo, 3);
                    loadTxtCT();
                    if (result_ct)
                    {
                        MessageBox.Show("Xóa hàng hóa thành công");
                    }
                }
                
                if (countItems == 1)
                {
                    bool result = QuanLyNhapXuat.ManageNhapHang(txtMaChungTu.Text, txtLoaiChungTu.Text, Convert.ToDateTime(txtNgayChungTu.Text), txtSoChungTu.Text,
                                                txtMaNguoiBan.Text, txtTenNguoiBan.Text, txtMaSoThueNguoiBan.Text,
                                                txtTaiKhoanNo.Text, txtTaiKhoanNoGTGT.Text, txtTaiKhoanCo.Text, txtDienGiai.Text,
                                                txtSoSeRi.Text, txtSoHoaDon.Text, Convert.ToDateTime(txtNgayHoaDon.Text), txtThueSuat.Text,
                                                txtThueGTGT.Text, txtMatHang.Text, Mode);
                    
                    MessageBox.Show("Hóa đơn đã được xóa!");
                    DataRow = 0;
                    loadNhapHang(DataRow);
                    defaultBtn();

                    //if(currentItem == dt.Rows.Count - 1)
                    //{
                    //    loadNhapHang(DataRow - 1);
                    //    DataRow = dt.Rows.Count - 1;
                    //    MessageBox.Show("Hóa đơn đã được xóa!");
                    //}

                }
                loadChiTietNhapHang();
            }
            else
            {
                return;
            }
        }


        private void btnMuc_Click(object sender, EventArgs e)
        {
            //Mode 4 = Insert data detail product
            Mode = 4;
            if (btnMuc.Tag == null)
            {
                btnPhieu.Tag = "toogled";

                txtCTMaHang.Text = "";
                txtCTDonGia.Text = "0";
                txtCTSL.Text = "0";
                txtCTDVT.Text = "";
                txtCTTenHang.Text = "";
                txtCTThanhTien.Text = "0";

                btnPhieu.Text = "GHI";

                txtCTMaHang.Enabled = true;
                txtCTSL.Enabled = true;

                btnUpdate.Enabled = false;
                btnSearch.Enabled = false;
                btnSQL.Enabled = false;

                btnCancel.Enabled = true;
                
                btnNext.Enabled = false;
                btnLast.Enabled = false;
                btnPrevious.Enabled = false;
                btnFirst.Enabled = false;

                dgvChiTietNhapHang.Enabled = false;
            }
            
           
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
            btnCancel.Enabled = false;
            btnNext.Enabled = true;
            btnLast.Enabled = true;
            btnPrevious.Enabled = true;
            btnFirst.Enabled = true;
            btnDelete.Enabled = false;

            btnMuc.Enabled = true;
            btnUpdate.Enabled = true;
            btnSearch.Enabled = true;
            btnSQL.Enabled = true;
            txtDienGiai.Enabled = false;
            txtLoaiChungTu.Enabled = false;
            txtNgayChungTu.Enabled = false;
            txtSoChungTu.Enabled = false;
            txtNgayHoaDon.Enabled = false;
            txtMaNguoiBan.Enabled = false;
            txtMaSoThueNguoiBan.Enabled = false;

            txtSoSeRi.Enabled = false;
            txtSoHoaDon.Enabled = false;
            txtMatHang.Enabled = false;
            txtTenNguoiBan.Enabled = false;
            txtTaiKhoanNo.Enabled = false;
            txtTaiKhoanCo.Enabled = false;
            txtTaiKhoanNoGTGT.Enabled = false;
            txtThueSuat.Enabled = false;
            txtThueGTGT.Enabled = false;

            txtCTMaHang.Enabled = false;
            txtCTSL.Enabled = false;
        }

        void defaultRow()
        {
            DataRow = 0;
            loadNhapHang(DataRow);
            loadChiTietNhapHang();
            loadTxtCT();
        }
        private void btnSQL_Click(object sender, EventArgs e)
        {

            frmTuNgayDenNgay objfrm = new frmTuNgayDenNgay();
            objfrm.ShowDialog();
            DataRow = 0;
            loadNhapHang(0);
            loadChiTietNhapHang();
            defaultBtn();
        }

        private void txtMaNguoiBan_Click(object sender, EventArgs e)
        {
            //AppEnv.Phieu = "tPhieuNhapHangHoa";
            // FormListPhieu objfrm = new FormListPhieu();
            //objfrm.ShowDialog();
            AppEnv.Phieu = "tDanhMucKhachHang";
            AppEnv.procedurePhieu = "p_TimKiemKhachHang";

            AppEnv.loadMode = 4;
            frmList objfrm = new frmList();
            objfrm.ShowDialog();

            txtMaNguoiBan.Text = AppEnv.maKHNH;
            txtTenNguoiBan.Text = AppEnv.tenKHNH;
            txtMaSoThueNguoiBan.Text = AppEnv.mstKHNH;
        }

        private void txtCTMaHang_Click(object sender, EventArgs e)
        {
            AppEnv.loadMode = 1;
            frmList objfrm = new frmList();
            objfrm.ShowDialog();

            
            
            txtCTMaHang.Text = AppEnv.maHHfXH;
            txtCTTenHang.Text = AppEnv.tenSPHHfXH;
            txtCTDVT.Text = AppEnv.dvtHHfXH;
            txtCTDonGia.Text = AppEnv.dgHHfXH.ToString();
        }

        private void txtTaiKhoanNo_Click(object sender, EventArgs e)
        {
            AppEnv.loadMode = 3;
            frmList objfrm = new frmList();
            objfrm.ShowDialog();

            txtTaiKhoanNo.Text = AppEnv.maPNTK;

        }

        private void txtTaiKhoanCo_Click(object sender, EventArgs e)
        {
            AppEnv.loadMode = 3;
            frmList objfrm = new frmList();
            objfrm.ShowDialog();

            txtTaiKhoanCo.Text = AppEnv.maPNTK;
        }


        private void txtTaiKhoanNoGTGT_Click(object sender, EventArgs e)
        {
            AppEnv.loadMode = 3;
            frmList objfrm = new frmList();
            objfrm.ShowDialog();
            
            txtTaiKhoanNoGTGT.Text = AppEnv.maPNTK;
        }

        private void txtMaNguoiBan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
