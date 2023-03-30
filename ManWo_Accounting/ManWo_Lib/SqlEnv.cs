using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ManWo_Lib
{
    public class SqlEnv
    {
        /*=========================================================
        Muc dich: ham ket noi voi CSDL SQL Server
        Input:
                Uname: ten nguoi dung ket noi den SQL Server
                UPassword : mat khau nguoi dung ket noi den SQL Server
        Output:
                TRUE: neu thanh cong
                FALSE: neu that bai
        =========================================================*/
        public static bool ConnectServerSQL(string UName, string UPassword)
        {
            bool succeed = false;

            string ConnectStr;


            //Thiet lap thong so connect string
            ConnectStr = "Provider=SQLOLEDB;Data Source=.\\SQLEXPRESS;Initial Catalog=DBAccounting;UID=" + UName + ";PWD=" + UPassword;
            try
            {
                AppEnv.WorkDB = new OleDbConnection(ConnectStr);
                AppEnv.WorkDB.Open();
                succeed = true;
            }
            catch
            {
                string message = "Mã nhân viên hoặc mật khẩu không chính xác.";
                string title = "Thông báo";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return succeed;
        }
    }
}
