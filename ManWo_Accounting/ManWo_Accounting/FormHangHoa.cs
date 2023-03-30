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
using System.Text.RegularExpressions;

namespace ManWo_Accounting
{
    public partial class FormHangHoa : Form
    {
        private OleDbDataAdapter objAdapter;
        private DataSet ds;
        private int Mode = 0;
        public FormHangHoa()
        {
            InitializeComponent();

            this.MouseWheel += FormHangHoa_MouseWheel;
        }

        private void FormHangHoa_MouseWheel(object sender, MouseEventArgs e)
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

        private void FormHangHoa_MouseLeave(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void FormHangHoa_MouseEnter(object sender, EventArgs e)
        {
            this.Focus();
        }

        public void ConfigDanhMucGripView()
        {
            HangHoaGridView.ReadOnly = true;
            HangHoaGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        public void showData()
        {
            string query = "select * from tDanhMucHangHoa";

            ds = new DataSet();
            objAdapter = new OleDbDataAdapter(query, AppEnv.WorkDB);
            objAdapter.Fill(ds, "tDanhMucHangHoa");
            HangHoaGridView.DataSource = ds.Tables["tDanhMucHangHoa"];
            HangHoaGridView.Columns[0].HeaderText = "Mã hàng";
            HangHoaGridView.Columns[1].HeaderText = "Tên hàng";
            HangHoaGridView.Columns[2].HeaderText = "Nhóm hàng";
            HangHoaGridView.Columns[3].HeaderText = "DVT";
            HangHoaGridView.Columns[4].HeaderText = "Số lượng tồn đầu";
            HangHoaGridView.Columns[5].HeaderText = "Thành tiền tồn đầu";
            HangHoaGridView.Columns[6].HeaderText = "Ngày tồn đầu";

            ConfigDanhMucGripView();
        }

        public void focusFirstRow()
        {
            HangHoaGridView.CurrentCell = HangHoaGridView.Rows[0].Cells[0];
            HangHoaGridView.CurrentCell.Selected = true;

            txt_maHH.Text = HangHoaGridView.Rows[0].Cells[0].Value.ToString();
            txt_tenHH.Text = HangHoaGridView.Rows[0].Cells[1].Value.ToString();
            txt_nhomHH.Text = HangHoaGridView.Rows[0].Cells[2].Value.ToString();
            txt_donViTinh.Text = HangHoaGridView.Rows[0].Cells[3].Value.ToString();
            txt_soLuongTonDau.Text = HangHoaGridView.Rows[0].Cells[4].Value.ToString();
            txt_thanhTienTonDau.Text = HangHoaGridView.Rows[0].Cells[5].Value.ToString();
            mboxNgayTon.Text = HangHoaGridView.Rows[0].Cells[6].Value.ToString();
        }

        public bool ManageProduct(string ma, string ten, string nhomhang, string dvt, float soluong, float thanhtien, DateTime ngayton, int mode)
        {

            bool QueryState = false;

            try
            {
                OleDbCommand commannd = new OleDbCommand("p_QuanLyDanhMucHH", AppEnv.WorkDB);
                if (ma == "")
                {
                    MessageBox.Show("Mã hàng hóa TRỐNG", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QueryState = false;
                }
                else
                {
                    commannd.Parameters.AddWithValue("@c_mahh", ma);
                    commannd.Parameters.AddWithValue("@c_tenhh", ten);
                    commannd.Parameters.AddWithValue("@c_nhomhang", nhomhang);
                    commannd.Parameters.AddWithValue("@c_dvt", dvt);
                    commannd.Parameters.AddWithValue("@n_soluongton", soluong);
                    commannd.Parameters.AddWithValue("@n_thanhtien", thanhtien);
                    commannd.Parameters.AddWithValue("@d_ngayton", ngayton);
                    commannd.Parameters.AddWithValue("@Mode", mode);

                    commannd.CommandType = CommandType.StoredProcedure;

                    commannd.ExecuteNonQuery();

                    QueryState = true;
                }
            }
            catch
            {
                MessageBox.Show("Mã hàng hóa đã tồn tại");
            }

            return QueryState;
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            txt_maHH.Enabled = false;
            txt_tenHH.Enabled = false;
            txt_nhomHH.Enabled = false;
            txt_donViTinh.Enabled = false;
            txt_soLuongTonDau.Enabled = false;
            txt_thanhTienTonDau.Enabled = false;
            mboxNgayTon.Enabled = false;
            showData();
            focusFirstRow();
        }

        private void btn_them_HangHoa_Click(object sender, EventArgs e)
        {
            float parseSoLuong, parseThanhTien;

            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
  
            if (mboxNgayTon.Enabled == true)
            {
                bool ngayTonHopLe = regex.IsMatch(mboxNgayTon.Text.Trim());

                if (!ngayTonHopLe)
                {
                    MessageBox.Show("Ngày tồn không hợp lệ");
                }
                else
                {
                    try
                    {
                        AppEnv.dNgayTonHangHoa = Convert.ToDateTime(mboxNgayTon.Text.Trim());
                    }
                    catch
                    {
                        MessageBox.Show("Năm không có ngày 29/02");
                    }
                }

            }


            if (btn_them_HangHoa.Tag == null)
            {
                //Mode 1 = Insert data
                Mode = 1;

                btn_them_HangHoa.Tag = "toogled";

                txt_maHH.Enabled = true;
                txt_tenHH.Enabled = true;
                txt_nhomHH.Enabled = true;
                txt_donViTinh.Enabled = true;
                txt_soLuongTonDau.Enabled = true;
                txt_thanhTienTonDau.Enabled = true;
                //btn_sua_HangHoa.Enabled = false;
                mboxNgayTon.Enabled = true;

                //clear data
                txt_maHH.Text = "";
                txt_tenHH.Text = "";
                txt_nhomHH.Text = "";
                txt_donViTinh.Text = "";
                txt_soLuongTonDau.Text = "";
                txt_thanhTienTonDau.Text = "";
                mboxNgayTon.Text = "";

                btn_them_HangHoa.Text = "GHI";
            }
            else
            {
                if (Mode == 1)
                {

                    if (float.TryParse(txt_soLuongTonDau.Text, out parseSoLuong) &&
                       float.TryParse(txt_thanhTienTonDau.Text, out parseThanhTien) &&
                       AppEnv.dNgayTonHangHoa != DateTime.MinValue)
                    {
                        bool Result = ManageProduct(txt_maHH.Text, txt_tenHH.Text,
                        txt_nhomHH.Text, txt_donViTinh.Text, parseSoLuong, parseThanhTien, AppEnv.dNgayTonHangHoa, Mode);
                        if (Result)
                        {
                            MessageBox.Show("Thêm thành công hàng hóa");
                            int lastestItems = HangHoaGridView.Rows.Count - 1;
                          
                            showData();
                            for (int i = 0; i < lastestItems; i++)
                            {
                                if (HangHoaGridView.Rows[i].Cells[0].Value.ToString() == txt_maHH.Text)
                                {
                                    HangHoaGridView.CurrentCell = HangHoaGridView.Rows[i].Cells[0];
                                    HangHoaGridView.CurrentCell.Selected = true;
                                }
                            }


                            btn_them_HangHoa.Tag = null;
                            txt_maHH.Enabled = false;
                            txt_tenHH.Enabled = false;
                            txt_nhomHH.Enabled = false;
                            txt_donViTinh.Enabled = false;
                            txt_soLuongTonDau.Enabled = false;
                            txt_thanhTienTonDau.Enabled = false;
                            mboxNgayTon.Enabled = false;
                            btn_them_HangHoa.Text = "THÊM";
                        }
                    }
                    else if (!float.TryParse(txt_soLuongTonDau.Text, out parseSoLuong))
                    {
                        MessageBox.Show("Số lượng tồn SAI");
                    }
                    else if (!float.TryParse(txt_thanhTienTonDau.Text, out parseThanhTien))
                    {
                        MessageBox.Show("Thành tiền SAI");
                    }

                }
                else if (Mode == 2)
                {
                    //Mode 2 = Update data

                    if (float.TryParse(txt_soLuongTonDau.Text, out parseSoLuong) &&
                       float.TryParse(txt_thanhTienTonDau.Text, out parseThanhTien)&&
                       AppEnv.dNgayTonHangHoa != DateTime.MinValue)
                    {
                        bool Result = ManageProduct(txt_maHH.Text, txt_tenHH.Text,
                        txt_nhomHH.Text, txt_donViTinh.Text, parseSoLuong, parseThanhTien, AppEnv.dNgayTonHangHoa, Mode);
                        if (Result)
                        {
                            MessageBox.Show("Sửa thành công hàng hóa");
                            //focus đúng item sửa
                            int currentItem = HangHoaGridView.CurrentCell.RowIndex;
                            showData();
                            HangHoaGridView.CurrentCell = HangHoaGridView.Rows[currentItem].Cells[0];
                            HangHoaGridView.CurrentCell.Selected = true;


                            btn_them_HangHoa.Tag = null;
                            txt_maHH.Enabled = false;
                            txt_tenHH.Enabled = false;
                            txt_nhomHH.Enabled = false;
                            txt_donViTinh.Enabled = false;
                            txt_soLuongTonDau.Enabled = false;
                            txt_thanhTienTonDau.Enabled = false;
                            mboxNgayTon.Enabled = false;
                            btn_them_HangHoa.Text = "THÊM";
                        }
                    }
                    else if (!float.TryParse(txt_soLuongTonDau.Text, out parseSoLuong))
                    {
                        MessageBox.Show("Số lượng tồn SAI");
                    }
                    else if (!float.TryParse(txt_thanhTienTonDau.Text, out parseThanhTien))
                    {
                        MessageBox.Show("Thành tiền SAI");
                    }
                }
            }
        }

        private void btn_sua_HangHoa_Click(object sender, EventArgs e)
        {
            //Mode 2 = Update data
            Mode = 2;
            txt_maHH.Enabled = false;
            if (btn_them_HangHoa.Tag == null)
            {
                btn_them_HangHoa.Tag = "toogled";

                txt_tenHH.Enabled = true;
                txt_nhomHH.Enabled = true;
                txt_donViTinh.Enabled = true;
                txt_soLuongTonDau.Enabled = true;
                txt_thanhTienTonDau.Enabled = true;
                mboxNgayTon.Enabled = true;
                btn_them_HangHoa.Text = "GHI";
            }
            else
            {
                int indexRow = HangHoaGridView.CurrentCell.RowIndex;
                txt_maHH.Text = HangHoaGridView.Rows[indexRow].Cells[0].Value.ToString();
                txt_tenHH.Text = HangHoaGridView.Rows[indexRow].Cells[1].Value.ToString();
                txt_nhomHH.Text = HangHoaGridView.Rows[indexRow].Cells[2].Value.ToString();
                txt_donViTinh.Text = HangHoaGridView.Rows[indexRow].Cells[3].Value.ToString();
                txt_soLuongTonDau.Text = HangHoaGridView.Rows[indexRow].Cells[4].Value.ToString();
                txt_thanhTienTonDau.Text = HangHoaGridView.Rows[indexRow].Cells[5].Value.ToString();
                mboxNgayTon.Text = HangHoaGridView.Rows[indexRow].Cells[6].Value.ToString();
            }
        }

        private void HangHoaGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = HangHoaGridView.CurrentCell.RowIndex;
            txt_maHH.Text = HangHoaGridView.Rows[indexRow].Cells[0].Value.ToString();
            txt_tenHH.Text = HangHoaGridView.Rows[indexRow].Cells[1].Value.ToString();
            txt_nhomHH.Text = HangHoaGridView.Rows[indexRow].Cells[2].Value.ToString();
            txt_donViTinh.Text = HangHoaGridView.Rows[indexRow].Cells[3].Value.ToString();
            txt_soLuongTonDau.Text = HangHoaGridView.Rows[indexRow].Cells[4].Value.ToString();
            txt_thanhTienTonDau.Text = HangHoaGridView.Rows[indexRow].Cells[5].Value.ToString();
            mboxNgayTon.Text = HangHoaGridView.Rows[indexRow].Cells[6].Value.ToString();
        }

        private void btn_xoa_HangHoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Xóa hàng hóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (rs == DialogResult.OK)
            {
                //Mode 3 = Delete data
                bool Resulte = ManageProduct(txt_maHH.Text, txt_tenHH.Text, txt_soLuongTonDau.Text,
                txt_nhomHH.Text, 0, 0, DateTime.Now, 3);
                if (Resulte == true)
                {
                    MessageBox.Show("Xóa hàng hóa thành công");
                    int previousItem = HangHoaGridView.CurrentCell.RowIndex - 1;
                    showData();
                    HangHoaGridView.CurrentCell = HangHoaGridView.Rows[previousItem].Cells[0];
                    HangHoaGridView.CurrentCell.Selected = true;
                }
            }
            else
            {
                return;
            }
        }

        private void btn_dung_Click(object sender, EventArgs e)
        {
            btn_them_HangHoa.Tag = null;
            txt_maHH.Enabled = false;
            txt_tenHH.Enabled = false;
            txt_nhomHH.Enabled = false;
            txt_donViTinh.Enabled = false;
            txt_soLuongTonDau.Enabled = false;
            txt_thanhTienTonDau.Enabled = false;
            mboxNgayTon.Enabled = false;
            btn_them_HangHoa.Text = "THÊM";
            btn_sua_HangHoa.Enabled = true;
            if (Mode == 1)
            {
                txt_maHH.Text = "";
                txt_tenHH.Text = "";
                txt_nhomHH.Text = "";
                txt_donViTinh.Text = "";
                txt_soLuongTonDau.Text = "";
                txt_thanhTienTonDau.Text = "";
                mboxNgayTon.Text = "";
                
            }
            focusFirstRow();
        }

        private void btnInDS_Click(object sender, EventArgs e)
        {
            Form frm = new report.frmReportHH();
            frm.ShowDialog();
        }
    }
}
