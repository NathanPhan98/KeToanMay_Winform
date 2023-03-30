using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManWo_Lib;

//https:///www.codeproject.com/Questions/5315059/Csharp-how-to-check-the-button-was-clicked-in-anot
//https:///askcodes.net/questions/drop-shadow-in-winforms-controls-
//https:///www.flaticon.com/

namespace ManWo_Accounting
{
    public partial class Form1 : Form
    {
        //Drop Shadow
        List<Control> shadowControls = new List<Control>();
        Bitmap shadowBmp = null;

        //Open many form in one form
        private Form currentChildForm;
        public Form1()
        {
            InitializeComponent();
            btn_DanhMuc.Image = imageList1.Images[2];
            btnNhapHang.Image = imageList1.Images[2];
            btnXuatHang.Image = imageList1.Images[2];

            shadowControls.Add(panel2);
            shadowControls.Add(panelDesktop);
        }

        //shadow effect
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (shadowBmp == null || shadowBmp.Size != this.Size)
            {
                shadowBmp?.Dispose();
                shadowBmp = new Bitmap(this.Width, this.Height, PixelFormat.Format32bppArgb);
            }
            foreach (Control control in shadowControls)
            {
                using (GraphicsPath gp = new GraphicsPath())
                {
                    gp.AddRectangle(new Rectangle(control.Location.X, control.Location.Y, control.Size.Width, control.Size.Height));
                    DrawShadowSmooth(gp, 100, 60, shadowBmp);
                }
                e.Graphics.DrawImage(shadowBmp, new Point(0, 0));
            }
        }

        //shadow effect
        private static void DrawShadowSmooth(GraphicsPath gp, int intensity, int radius, Bitmap dest)
        {
            using (Graphics g = Graphics.FromImage(dest))
            {
                g.Clear(Color.Transparent);
                g.CompositingMode = CompositingMode.SourceCopy;
                double alpha = 0;
                double astep = 0;
                double astepstep = (double)intensity / radius / (radius / 2D);
                for (int thickness = radius; thickness > 0; thickness--)
                {
                    using (Pen p = new Pen(Color.FromArgb((int)alpha, 0, 0, 0), thickness))
                    {
                        p.LineJoin = LineJoin.Round;
                        g.DrawPath(p, gp);
                    }
                    alpha += astep;
                    astep += astepstep;
                }
            }
        }

        
        public void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btn_DanhMuc_Click(object sender, EventArgs e)
        {
            focusColor(btn_DanhMuc);
            defaultColor(btnNhapHang);
            defaultColor(btnXuatHang);

            dropDownDanhMuc.Show(btn_DanhMuc, btn_DanhMuc.Width - 5, 0);
        }

        private void KhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_title_CurrentForm.Text = dropDownDanhMuc.Items[0].Text;
            OpenChildForm(new FormKhachHang());
            lbl_title_CurrentForm.Visible = true;
        }

        private void TaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_title_CurrentForm.Text = dropDownDanhMuc.Items[1].Text;
            OpenChildForm(new FormTaiKhoan());
            lbl_title_CurrentForm.Visible = true;
        }

        private void HangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbl_title_CurrentForm.Text = dropDownDanhMuc.Items[2].Text;
            OpenChildForm(new FormHangHoa());
            lbl_title_CurrentForm.Visible = true;
        }



        private void focusColor(Button btn)
        {
            btn.Image = imageList1.Images[0];
            btn.BackColor = Color.FromArgb(34, 36, 69);
        }
        private void defaultColor(Button btn)
        {
            btn.Image = imageList1.Images[2];
            btn.BackColor = Color.White;
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            lbl_title_CurrentForm.Visible = true;
            lbl_title_CurrentForm.Text = "Nhập hàng hóa";
            focusColor(btnNhapHang);
            defaultColor(btn_DanhMuc);
            defaultColor(btnXuatHang);
            OpenChildForm(new FormNhapHang());
        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            lbl_title_CurrentForm.Visible = true;
            lbl_title_CurrentForm.Text = "Xuất hàng hóa";
            focusColor(btnXuatHang);
            defaultColor(btn_DanhMuc);
            defaultColor(btnNhapHang);
            OpenChildForm(new FormXuatHang());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HandleLogin();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(btnLogout.Tag == null)
            {
                HandleLogin();
            }
            else
            {
                lblCurrentUser.Text = "";
                btnLogout.Tag = null;
                btnLogout.Text = "Đăng nhập";
                AppEnv.UserName = null;
                AppEnv.WorkDB = null;
                AppEnv.dTuNgay = DateTime.MinValue;
                AppEnv.dDenNgay = DateTime.MinValue;
                lbl_title_CurrentForm.Visible = false;
                btnNhapHang.Enabled = false;
                btn_DanhMuc.Enabled = false;
                btnXuatHang.Enabled = false;
                lbl_title_CurrentForm.Text = "";
                OpenChildForm(new FormBlank());
                HandleLogin();
            }
        }

        public void HandleLogin()
        {
            FormLogin frmLogin = new FormLogin();
            frmLogin.ShowDialog();

            if (AppEnv.UserName == null)
            {
                btnNhapHang.Enabled = false;
                btn_DanhMuc.Enabled = false;
                btnXuatHang.Enabled = false;
            }
            else
            {
                lblCurrentUser.Text = AppEnv.UserName;
                lblCurrentUser.Visible = true;
                btnNhapHang.Enabled = true;
                btn_DanhMuc.Enabled = true;
                btnXuatHang.Enabled = true;
                btnLogout.Visible = true;
                btnLogout.Tag = "Logout";
                btnLogout.Text = "Đăng xuất";
                if (AppEnv.dTuNgay == DateTime.MinValue || AppEnv.dDenNgay == DateTime.MinValue)
                {
                    frmTuNgayDenNgay Ngay = new frmTuNgayDenNgay();
                    Ngay.ShowDialog();
                }
            }
        }
    }
}
