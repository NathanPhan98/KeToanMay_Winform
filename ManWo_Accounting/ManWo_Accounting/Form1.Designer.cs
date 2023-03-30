
namespace ManWo_Accounting
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_DanhMuc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXuatHang = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_title_CurrentForm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dropDownDanhMuc = new ManWo_Accounting.DropDownMenu(this.components);
            this.KhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HangHoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.dropDownDanhMuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "default_home.png");
            this.imageList1.Images.SetKeyName(1, "active_home3.png");
            this.imageList1.Images.SetKeyName(2, "gray_home.png");
            // 
            // btn_DanhMuc
            // 
            this.btn_DanhMuc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_DanhMuc.BackColor = System.Drawing.Color.White;
            this.btn_DanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DanhMuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DanhMuc.ForeColor = System.Drawing.Color.White;
            this.btn_DanhMuc.Location = new System.Drawing.Point(-15, 50);
            this.btn_DanhMuc.Name = "btn_DanhMuc";
            this.btn_DanhMuc.Size = new System.Drawing.Size(91, 56);
            this.btn_DanhMuc.TabIndex = 5;
            this.btn_DanhMuc.UseVisualStyleBackColor = false;
            this.btn_DanhMuc.Click += new System.EventHandler(this.btn_DanhMuc_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnXuatHang);
            this.panel2.Controls.Add(this.btnNhapHang);
            this.panel2.Controls.Add(this.btn_DanhMuc);
            this.panel2.ForeColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(26, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 452);
            this.panel2.TabIndex = 16;
            // 
            // btnXuatHang
            // 
            this.btnXuatHang.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnXuatHang.BackColor = System.Drawing.Color.White;
            this.btnXuatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatHang.ForeColor = System.Drawing.Color.White;
            this.btnXuatHang.ImageList = this.imageList1;
            this.btnXuatHang.Location = new System.Drawing.Point(-15, 174);
            this.btnXuatHang.Name = "btnXuatHang";
            this.btnXuatHang.Size = new System.Drawing.Size(91, 56);
            this.btnXuatHang.TabIndex = 8;
            this.btnXuatHang.UseVisualStyleBackColor = false;
            this.btnXuatHang.Click += new System.EventHandler(this.btnXuatHang_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNhapHang.BackColor = System.Drawing.Color.White;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnNhapHang.ImageList = this.imageList1;
            this.btnNhapHang.Location = new System.Drawing.Point(-15, 112);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(91, 56);
            this.btnNhapHang.TabIndex = 7;
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoScroll = true;
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.Color.Black;
            this.panelDesktop.Location = new System.Drawing.Point(116, 160);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(994, 500);
            this.panelDesktop.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 733);
            this.panel1.TabIndex = 31;
            // 
            // lbl_title_CurrentForm
            // 
            this.lbl_title_CurrentForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(69)))));
            this.lbl_title_CurrentForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_title_CurrentForm.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title_CurrentForm.ForeColor = System.Drawing.Color.White;
            this.lbl_title_CurrentForm.Location = new System.Drawing.Point(64, 28);
            this.lbl_title_CurrentForm.Name = "lbl_title_CurrentForm";
            this.lbl_title_CurrentForm.Size = new System.Drawing.Size(346, 45);
            this.lbl_title_CurrentForm.TabIndex = 23;
            this.lbl_title_CurrentForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1097, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Xin chào";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblCurrentUser);
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(116, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1074, 85);
            this.panel3.TabIndex = 32;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUser.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCurrentUser.Location = new System.Drawing.Point(1186, 30);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(143, 27);
            this.lblCurrentUser.TabIndex = 30;
            this.lblCurrentUser.Text = "CurrentUser";
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCurrentUser.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(1404, 29);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(118, 29);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "Đăng nhập";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1110, 85);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(80, 648);
            this.panel5.TabIndex = 35;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(116, 660);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(994, 73);
            this.panel6.TabIndex = 36;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbl_title_CurrentForm);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(116, 85);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(994, 75);
            this.panel7.TabIndex = 24;
            // 
            // dropDownDanhMuc
            // 
            this.dropDownDanhMuc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dropDownDanhMuc.IsMainMenu = false;
            this.dropDownDanhMuc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KhachHangToolStripMenuItem,
            this.TaiKhoanToolStripMenuItem,
            this.HangHoaToolStripMenuItem});
            this.dropDownDanhMuc.MenuItemHeight = 25;
            this.dropDownDanhMuc.MenuItemTextColor = System.Drawing.Color.DimGray;
            this.dropDownDanhMuc.Name = "dropDownMenu1";
            this.dropDownDanhMuc.PrimaryColor = System.Drawing.Color.MediumSlateBlue;
            this.dropDownDanhMuc.Size = new System.Drawing.Size(225, 104);
            // 
            // KhachHangToolStripMenuItem
            // 
            this.KhachHangToolStripMenuItem.Name = "KhachHangToolStripMenuItem";
            this.KhachHangToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.KhachHangToolStripMenuItem.Text = "Danh mục khách hàng";
            this.KhachHangToolStripMenuItem.Click += new System.EventHandler(this.KhachHangToolStripMenuItem_Click);
            // 
            // TaiKhoanToolStripMenuItem
            // 
            this.TaiKhoanToolStripMenuItem.Name = "TaiKhoanToolStripMenuItem";
            this.TaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.TaiKhoanToolStripMenuItem.Text = "Danh mục tài khoản";
            this.TaiKhoanToolStripMenuItem.Click += new System.EventHandler(this.TaiKhoanToolStripMenuItem_Click);
            // 
            // HangHoaToolStripMenuItem
            // 
            this.HangHoaToolStripMenuItem.Name = "HangHoaToolStripMenuItem";
            this.HangHoaToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.HangHoaToolStripMenuItem.Text = "Danh mục hàng hóa";
            this.HangHoaToolStripMenuItem.Click += new System.EventHandler(this.HangHoaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1190, 733);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm kế toán";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.dropDownDanhMuc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_DanhMuc;
        private DropDownMenu dropDownDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem KhachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TaiKhoanToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.ToolStripMenuItem HangHoaToolStripMenuItem;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Button btnXuatHang;
        private System.Windows.Forms.Label lbl_title_CurrentForm;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}

