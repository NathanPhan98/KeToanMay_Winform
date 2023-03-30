using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using ManWo_Lib;

using System.Data;

namespace ManWo_Lib
{
    public class QuanLyNhapXuat
    {

        //-- Nhap hang
        public static bool ManageNhapHang(string maCT, string loaiCT, DateTime ngayCT, string soCT, string maNB, string tenNB, string mstNB, string tkNo,
                            string tkNoGTGT, string tkCo, string dienGiai, string soSeRi, string soHD, DateTime ngayHD, string thueSuat,
                            string thueGTGT, string matHang, int mode)
        {

            bool QueryState = false;

            try
            {
                OleDbCommand commannd = new OleDbCommand("p_QuanLyPhieuNhapHangHoa", AppEnv.WorkDB);
                if (maCT == "")
                {
                    MessageBox.Show("Mã nhập hàng TRỐNG", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QueryState = false;
                }
                else
                {
                    commannd.Parameters.AddWithValue("@c_maChungTu", maCT);
                    commannd.Parameters.AddWithValue("@c_loaiChungTu", loaiCT);
                    commannd.Parameters.AddWithValue("@d_ngayChungTu", ngayCT);
                    commannd.Parameters.AddWithValue("@c_soChungTu", soCT);
                    commannd.Parameters.AddWithValue("@c_maNguoiBan", maNB);
                    commannd.Parameters.AddWithValue("@c_tenNguoiBan", tenNB);
                    commannd.Parameters.AddWithValue("@c_maSoThueNguoiBan", mstNB);
                    commannd.Parameters.AddWithValue("@c_taiKhoanNo", tkNo);
                    commannd.Parameters.AddWithValue("@c_taiKhoanNoGTGT", tkNoGTGT);
                    commannd.Parameters.AddWithValue("@c_taiKhoanCo", tkCo);
                    commannd.Parameters.AddWithValue("@c_dienGiai", dienGiai);
                    commannd.Parameters.AddWithValue("@c_soSeRi", soSeRi);
                    commannd.Parameters.AddWithValue("@c_soHoaDon", soHD);
                    commannd.Parameters.AddWithValue("@d_ngayHoaDon", ngayHD);
                    commannd.Parameters.AddWithValue("@n_thueSuat", thueSuat);
                    commannd.Parameters.AddWithValue("@n_thueGTGT", thueGTGT);
                    commannd.Parameters.AddWithValue("@c_matHang", matHang);



                    commannd.Parameters.AddWithValue("@Mode", mode);

                    commannd.CommandType = CommandType.StoredProcedure;

                    commannd.ExecuteNonQuery();

                    QueryState = true;
                }
            }
            catch
            {
                MessageBox.Show("Mã Nhập hàng đã tồn tại");
            }

            return QueryState;
        }
        public static bool manageCTNhapHang(string maCT, string maHang, string dVT, float soLuong, float donGia, float thanhtien, int maso, int mode)
        {
            bool QueryState = false;

            if (maHang == "")
            {
                MessageBox.Show("Mã hàng hóa trống");
            }

            try
            {
                OleDbCommand commannd = new OleDbCommand("p_QuanLyPhieuNhapHangHoaChiTiet", AppEnv.WorkDB);

                commannd.CommandType = CommandType.StoredProcedure;

                commannd.Parameters.AddWithValue("@c_maChungTu", maCT);
                commannd.Parameters.AddWithValue("@c_MaHang", maHang);
                commannd.Parameters.AddWithValue("@c_DonViTinh", dVT);
                commannd.Parameters.AddWithValue("@n_SoLuong", soLuong);
                commannd.Parameters.AddWithValue("@n_DonGia", donGia);
                commannd.Parameters.AddWithValue("@n_ThanhTien", thanhtien);
                commannd.Parameters.AddWithValue("@maSoThamChieu", maso);
                commannd.Parameters.AddWithValue("@Mode", mode);

                commannd.ExecuteNonQuery();

                QueryState = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }



            return QueryState;
        }

        //-- Xuat hang
        public static bool ManageXuatHang(string maCT, string loaiCT, DateTime ngayCT, string soCT, string maKH, string tenKH, string mst, 
                                string tkNoGiaVon, string tkCoGiaVon, string tkNoGiaBan, string tkCoGiaBan,string tkCoGTGT,
                                string dienGiai, string matHang, string thueSuat, string thueGTGT, string soSeRi, string soHD, int mode)
        {

            bool QueryState = false;

            try
            {
                OleDbCommand commannd = new OleDbCommand("p_QuanLyPhieuXuatHangHoa", AppEnv.WorkDB);
                if (maCT == "")
                {
                    MessageBox.Show("Mã nhập hàng TRỐNG", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    QueryState = false;
                }
                else
                {
                    commannd.Parameters.AddWithValue("@c_maChungTu", maCT);
                    commannd.Parameters.AddWithValue("@c_loaiChungTu", loaiCT);
                    commannd.Parameters.AddWithValue("@d_ngayChungTu", ngayCT);
                    commannd.Parameters.AddWithValue("@c_soChungTu", soCT);
                    commannd.Parameters.AddWithValue("@c_maKhachHang", maKH);
                    commannd.Parameters.AddWithValue("@c_tenKhachHang", tenKH);
                    commannd.Parameters.AddWithValue("@c_maSoThue", mst);
                    commannd.Parameters.AddWithValue("@c_TaiKhoanNoGiaVon", tkNoGiaVon);
                    commannd.Parameters.AddWithValue("@c_TaiKhoanCoGiaVon", tkCoGiaVon);
                    commannd.Parameters.AddWithValue("@c_TaiKhoanNoGiaBan", tkNoGiaBan);
                    commannd.Parameters.AddWithValue("@c_TaiKhoanCoGiaBan", tkCoGiaBan);
                    commannd.Parameters.AddWithValue("@c_TaiKhoanCoGTGT", tkCoGTGT);
                    commannd.Parameters.AddWithValue("@c_dienGiai", dienGiai);
                    commannd.Parameters.AddWithValue("@c_matHang", matHang);
                    commannd.Parameters.AddWithValue("@n_thueSuat", thueSuat);
                    commannd.Parameters.AddWithValue("@n_thueGTGT", thueGTGT);
                    commannd.Parameters.AddWithValue("@c_soSeRi", soSeRi);
                    commannd.Parameters.AddWithValue("@c_soHoaDon", soHD);


                    commannd.Parameters.AddWithValue("@Mode", mode);

                    commannd.CommandType = CommandType.StoredProcedure;

                    commannd.ExecuteNonQuery();

                    QueryState = true;
                }
            }
            catch
            {
                MessageBox.Show("Mã Nhập hàng đã tồn tại");
            }

            return QueryState;
        }

        public static bool manageCTXuatHang(string maCT, string maHang, string dVT, float soLuong,
                                float donGiaVon, float tTGiaVon, float donGiaBan, float tTGiaBan, string maChungTuNhap, int mode)
        {
            bool QueryState = false;

            if (maHang == "")
            {
                MessageBox.Show("Mã hàng hóa trống");
            }

            try
            {
                OleDbCommand commannd = new OleDbCommand("p_QuanLyPhieuXuatHangHoaChiTiet", AppEnv.WorkDB);

                commannd.CommandType = CommandType.StoredProcedure;

                commannd.Parameters.AddWithValue("@c_maChungTu", maCT);
                commannd.Parameters.AddWithValue("@c_MaHang", maHang);
                commannd.Parameters.AddWithValue("@c_DonViTinh", dVT);
                commannd.Parameters.AddWithValue("@n_SoLuong", soLuong);
                commannd.Parameters.AddWithValue("@n_DonGiaVon", donGiaVon);
                commannd.Parameters.AddWithValue("@n_ThanhTienVon", tTGiaVon);
                commannd.Parameters.AddWithValue("@n_DonGiaBan", donGiaBan);
                commannd.Parameters.AddWithValue("@n_ThanhTienBan", tTGiaBan);
                commannd.Parameters.AddWithValue("@maSoThamChieu", maChungTuNhap);
                commannd.Parameters.AddWithValue("@Mode", mode);

                commannd.ExecuteNonQuery();

                QueryState = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }



            return QueryState;
        }
    }
}
