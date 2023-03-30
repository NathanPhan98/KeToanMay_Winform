
namespace ManWo_Accounting
{
    partial class FormKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.KhachHangGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fax = new System.Windows.Forms.TextBox();
            this.txt_dt = new System.Windows.Forms.TextBox();
            this.txt_thanhpho = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_sothue = new System.Windows.Forms.TextBox();
            this.txt_tenKH = new System.Windows.Forms.TextBox();
            this.txt_maKH = new System.Windows.Forms.TextBox();
            this.btn_in_KhachHang = new System.Windows.Forms.Button();
            this.btn_dung = new System.Windows.Forms.Button();
            this.btn_xoa_Khachhang = new System.Windows.Forms.Button();
            this.btn_sua_KhachHang = new System.Windows.Forms.Button();
            this.btn_them_KhachHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // KhachHangGridView
            // 
            this.KhachHangGridView.AllowUserToAddRows = false;
            this.KhachHangGridView.AllowUserToDeleteRows = false;
            this.KhachHangGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KhachHangGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.KhachHangGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.KhachHangGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.KhachHangGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.KhachHangGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KhachHangGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.KhachHangGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KhachHangGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.KhachHangGridView.EnableHeadersVisualStyles = false;
            this.KhachHangGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.KhachHangGridView.Location = new System.Drawing.Point(12, 253);
            this.KhachHangGridView.MultiSelect = false;
            this.KhachHangGridView.Name = "KhachHangGridView";
            this.KhachHangGridView.ReadOnly = true;
            this.KhachHangGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.KhachHangGridView.RowHeadersVisible = false;
            this.KhachHangGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.KhachHangGridView.RowTemplate.Height = 24;
            this.KhachHangGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KhachHangGridView.Size = new System.Drawing.Size(1100, 275);
            this.KhachHangGridView.TabIndex = 0;
            this.KhachHangGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KhachHangGridView_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(765, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "Fax";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Điện Thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Thành Phố";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "MST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // txt_fax
            // 
            this.txt_fax.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fax.Location = new System.Drawing.Point(768, 44);
            this.txt_fax.Name = "txt_fax";
            this.txt_fax.Size = new System.Drawing.Size(223, 30);
            this.txt_fax.TabIndex = 24;
            // 
            // txt_dt
            // 
            this.txt_dt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dt.Location = new System.Drawing.Point(398, 184);
            this.txt_dt.Name = "txt_dt";
            this.txt_dt.Size = new System.Drawing.Size(220, 30);
            this.txt_dt.TabIndex = 23;
            // 
            // txt_thanhpho
            // 
            this.txt_thanhpho.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thanhpho.Location = new System.Drawing.Point(398, 115);
            this.txt_thanhpho.Name = "txt_thanhpho";
            this.txt_thanhpho.Size = new System.Drawing.Size(220, 30);
            this.txt_thanhpho.TabIndex = 22;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(398, 44);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(220, 30);
            this.txt_diachi.TabIndex = 21;
            // 
            // txt_sothue
            // 
            this.txt_sothue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sothue.Location = new System.Drawing.Point(47, 185);
            this.txt_sothue.Name = "txt_sothue";
            this.txt_sothue.Size = new System.Drawing.Size(214, 30);
            this.txt_sothue.TabIndex = 20;
            // 
            // txt_tenKH
            // 
            this.txt_tenKH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenKH.Location = new System.Drawing.Point(47, 115);
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.Size = new System.Drawing.Size(214, 30);
            this.txt_tenKH.TabIndex = 19;
            // 
            // txt_maKH
            // 
            this.txt_maKH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maKH.Location = new System.Drawing.Point(47, 44);
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.Size = new System.Drawing.Size(214, 30);
            this.txt_maKH.TabIndex = 18;
            // 
            // btn_in_KhachHang
            // 
            this.btn_in_KhachHang.BackColor = System.Drawing.Color.DarkGray;
            this.btn_in_KhachHang.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_in_KhachHang.Location = new System.Drawing.Point(768, 179);
            this.btn_in_KhachHang.Name = "btn_in_KhachHang";
            this.btn_in_KhachHang.Size = new System.Drawing.Size(223, 37);
            this.btn_in_KhachHang.TabIndex = 45;
            this.btn_in_KhachHang.Text = "In Danh Sách Khách Hàng";
            this.btn_in_KhachHang.UseVisualStyleBackColor = false;
            this.btn_in_KhachHang.Click += new System.EventHandler(this.btn_in_KhachHang_Click);
            // 
            // btn_dung
            // 
            this.btn_dung.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_dung.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dung.Location = new System.Drawing.Point(782, 585);
            this.btn_dung.Name = "btn_dung";
            this.btn_dung.Size = new System.Drawing.Size(137, 43);
            this.btn_dung.TabIndex = 49;
            this.btn_dung.Text = "Dừng";
            this.btn_dung.UseVisualStyleBackColor = false;
            this.btn_dung.Click += new System.EventHandler(this.btn_dung_Click);
            // 
            // btn_xoa_Khachhang
            // 
            this.btn_xoa_Khachhang.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_xoa_Khachhang.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa_Khachhang.Location = new System.Drawing.Point(594, 585);
            this.btn_xoa_Khachhang.Name = "btn_xoa_Khachhang";
            this.btn_xoa_Khachhang.Size = new System.Drawing.Size(148, 43);
            this.btn_xoa_Khachhang.TabIndex = 46;
            this.btn_xoa_Khachhang.Text = "Xóa";
            this.btn_xoa_Khachhang.UseVisualStyleBackColor = false;
            this.btn_xoa_Khachhang.Click += new System.EventHandler(this.btn_xoa_Khachhang_Click_1);
            // 
            // btn_sua_KhachHang
            // 
            this.btn_sua_KhachHang.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_sua_KhachHang.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua_KhachHang.Location = new System.Drawing.Point(412, 585);
            this.btn_sua_KhachHang.Name = "btn_sua_KhachHang";
            this.btn_sua_KhachHang.Size = new System.Drawing.Size(148, 43);
            this.btn_sua_KhachHang.TabIndex = 47;
            this.btn_sua_KhachHang.Text = "Sửa";
            this.btn_sua_KhachHang.UseVisualStyleBackColor = false;
            this.btn_sua_KhachHang.Click += new System.EventHandler(this.btn_sua_KhachHang_Click_1);
            // 
            // btn_them_KhachHang
            // 
            this.btn_them_KhachHang.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_them_KhachHang.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them_KhachHang.Location = new System.Drawing.Point(225, 585);
            this.btn_them_KhachHang.Name = "btn_them_KhachHang";
            this.btn_them_KhachHang.Size = new System.Drawing.Size(148, 43);
            this.btn_them_KhachHang.TabIndex = 48;
            this.btn_them_KhachHang.Text = "Thêm";
            this.btn_them_KhachHang.UseVisualStyleBackColor = false;
            this.btn_them_KhachHang.Click += new System.EventHandler(this.btn_them_KhachHang_Click_1);
            // 
            // FormKhachHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.btn_dung);
            this.Controls.Add(this.btn_xoa_Khachhang);
            this.Controls.Add(this.btn_sua_KhachHang);
            this.Controls.Add(this.btn_them_KhachHang);
            this.Controls.Add(this.btn_in_KhachHang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_fax);
            this.Controls.Add(this.txt_dt);
            this.Controls.Add(this.txt_thanhpho);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_sothue);
            this.Controls.Add(this.txt_tenKH);
            this.Controls.Add(this.txt_maKH);
            this.Controls.Add(this.KhachHangGridView);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.MouseEnter += new System.EventHandler(this.FormKhachHang_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FormKhachHang_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView KhachHangGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_fax;
        private System.Windows.Forms.TextBox txt_dt;
        private System.Windows.Forms.TextBox txt_thanhpho;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_sothue;
        private System.Windows.Forms.TextBox txt_tenKH;
        private System.Windows.Forms.TextBox txt_maKH;
        private System.Windows.Forms.Button btn_in_KhachHang;
        private System.Windows.Forms.Button btn_dung;
        private System.Windows.Forms.Button btn_xoa_Khachhang;
        private System.Windows.Forms.Button btn_sua_KhachHang;
        private System.Windows.Forms.Button btn_them_KhachHang;
    }
}