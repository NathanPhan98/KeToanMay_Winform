using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;


namespace ManWo_Lib
{
    //=========================================
    //khai bao cac thong so dung chung cho chuong trinh
    //=========================================
    public class AppEnv
    {
        //=========================================
        //khai bao cac thong so connection den Database
        //=========================================
        public static OleDbConnection WorkDB;
        public static OleDbConnection AdminWorkDB;
        public static bool connected;
        public static string SqlStatement;
        public static bool LoginSuccess;
        //=========================================
        //khai bao cac thong so ve User
        //=========================================
        public static string UsrRole; // Vai tro cua User.
        public static string UsrGroup; // nhom cua User
        public static DateTime BusDate; //Ngay lam viec
        public static string UserID;// user ID
        public static string UserName; // username login
        public static string UserPwd; // user password login
        public static string MaXN; // ma cong ty cua user login
        public static string TenXN; //ten cong ty cua user login
        public static string UserBirthday;
        public static string mstrKey;
        public static string mstrText;
        //=========================================
        //khai bao cac thong so cua chuong trinh ung dung duoi client
        //=========================================
        public static string AppPath;
        public static string ReportPath;
        public static string SettingReport; // thiet lap ket noi connection cua Crystal Report
        //=========================================
        //khai bao cac bien dung chung cho ca module
        //=========================================
        public static DateTime dTuNgay;
        public static DateTime dDenNgay;
        public static DateTime dNgayTonHangHoa;
        public static bool FormOpen;

        public static string Phieu; //để biết đang mở phiếu nào để load phiếu xuất hay nhập để tìm kiếm
        public static string procedurePhieu;// giống trên để load procedure
        public static string procedureSLPhieu;// giống trên
        public static string searchValue;


        //-- Load form danh sach trong Xuat Hang
        public static int loadMode;
        // 1 load tDanhMucHangHoa
        // 2 load tPhieuNhapHangHoaChiTiet
        // 3 load tDanhMucTaiKhoan
        // 4 load tDanhMucTaiKhoan

        //== Search HH from XuatHang
        public static string maHHfXH;
        public static string dvtHHfXH;
        public static float dgHHfXH;
        public static string tenSPHHfXH;

        //== Search Phieu nhap
        public static string phieuNhapHHfXH;

        //-- so thu tu phieu
        public static int maCTXHSearch;

        // ma tai khoan
        public static string maPNTK;

        // Ten khach hang load vao 
        public static string maKHNH;
        public static string tenKHNH;
        public static string mstKHNH;

        public static DataSet ReadDataSet(string sql)
        {
            DataSet dset = new DataSet();

            OleDbDataAdapter myAdapter = new OleDbDataAdapter(sql, WorkDB);

            myAdapter.Fill(dset);

            return dset;
        }
    }
}
