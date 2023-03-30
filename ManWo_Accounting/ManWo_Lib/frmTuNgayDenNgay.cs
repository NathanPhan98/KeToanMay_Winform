using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using ManWo_Lib;

namespace ManWo_Accounting
{
    public partial class frmTuNgayDenNgay : Form
    {
        
        public frmTuNgayDenNgay()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string tuNgay = mboxTuNgay.Text;
            string denNgay = mboxDenNgay.Text;
            int ngayHopLe = -2;//-2 = chưa có dữ liệu


            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            
            bool tuNgayHopLe = regex.IsMatch(tuNgay.Trim());
            bool denNgayHopLe = regex.IsMatch(denNgay.Trim());
            
            if (!tuNgayHopLe)
            {
                MessageBox.Show("Từ ngày không hợp lệ");
            }
            else if (!denNgayHopLe)
            {
                MessageBox.Show("Đến ngày không hợp lệ");
            }
            else
            {
                try
                {
                    ngayHopLe = DateTime.Compare(Convert.ToDateTime(tuNgay), Convert.ToDateTime(denNgay));
                }
                catch
                {
                    try
                    {
                        Convert.ToDateTime(tuNgay);
                    }
                    catch
                    {
                        MessageBox.Show("Từ ngày năm không nhuần");
                    }
                    try
                    {
                        Convert.ToDateTime(denNgay);
                    }
                    catch
                    {
                        MessageBox.Show("Đến ngày năm không nhuần");
                    }
                }  
            }


            if(ngayHopLe != -2)
            {
                if (DateTime.Parse(tuNgay) > DateTime.Now)
                {
                    mboxTuNgay.Text = DateTime.Now.ToString();
                    AppEnv.dTuNgay = DateTime.Now;
                }
                else if (DateTime.Parse(denNgay) > DateTime.Now)
                {
                    mboxDenNgay.Text = DateTime.Now.ToString();
                    AppEnv.dDenNgay = DateTime.Now;
                }

                if (ngayHopLe == -1 || ngayHopLe == 0)
                {
                    //-1 : đến ngày > từ ngày 
                    // 0 : từ ngày = đến ngày

                    AppEnv.dTuNgay = Convert.ToDateTime(tuNgay);
                    AppEnv.dDenNgay = Convert.ToDateTime(denNgay);
                    

                    this.Close();
                }
                else if (ngayHopLe == 1)
                {
                    //1 : từ ngày > đến ngày
                    MessageBox.Show("Đến ngày không hợp lệ");
                }

                
            }

        }

        private void btnNhapTuDong_Click(object sender, EventArgs e)
        {
            mboxTuNgay.Text = "11/11/2000";
            mboxDenNgay.Text = "11/11/2020";
        }
    }
}
