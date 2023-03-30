using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManWo_Lib;

namespace ManWo_Accounting
{
    
    public partial class FormLogin : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public static string CurrentUser;
        public FormLogin()
        {
            InitializeComponent();
            txt_password.PasswordChar = '*';
            pictureBox1.Image = imageList1.Images[1];
            pictureBox2.Image = imageList1.Images[0];
            pictureBox3.Image = imageList2.Images[0];
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (SqlEnv.ConnectServerSQL(txt_username.Text.Trim(), txt_password.Text.Trim()))
            {
                AppEnv.UserName = txt_username.Text.Trim();

                //this.Hide();
                //Form MainApp = new Form1();
                //MainApp.ShowDialog();
                this.Close();
            };
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txt_username_Click(object sender, EventArgs e)
        {
            if(txt_password.Text == "Tên đăng nhập")
                txt_username.Clear();
            txt_username.ForeColor = Color.Black;
            panel1.BackColor = Color.FromArgb(128, 128, 255);

            txt_password.ForeColor = Color.Black;
            panel2.BackColor = Color.FromArgb(128, 128, 255);
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == "Mật khẩu")
                txt_password.Clear();
            txt_password.ForeColor = Color.Black;
            panel2.BackColor = Color.FromArgb(128, 128, 255);

            txt_username.ForeColor = Color.Black;
            panel1.BackColor = Color.FromArgb(128, 128, 255);
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void FormLogin_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void FormLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                //MessageBox.Show(e.Location.ToString());      
                Point p = PointToScreen(e.Location);
                //MessageBox.Show(p.ToString());
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }


        // này cho a đăng nhập cho lẹ, khỏi thay đổi source code
        private void btnLoginTan_Click(object sender, EventArgs e)
        {
            if (SqlEnv.ConnectServerSQL("admintan", "123"))
            {
                AppEnv.UserName = txt_username.Text.Trim();

                //this.Hide();
                //Form MainApp = new Form1();
                //MainApp.ShowDialog();
                this.Close();
            };
        }


    }
}
