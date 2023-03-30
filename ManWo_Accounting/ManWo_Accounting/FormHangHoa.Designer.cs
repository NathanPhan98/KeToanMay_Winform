
namespace ManWo_Accounting
{
    partial class FormHangHoa
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
            this.btn_xoa_HangHoa = new System.Windows.Forms.Button();
            this.btn_sua_HangHoa = new System.Windows.Forms.Button();
            this.btn_them_HangHoa = new System.Windows.Forms.Button();
            this.HangHoaGridView = new System.Windows.Forms.DataGridView();
            this.btn_dung = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mboxNgayTon = new System.Windows.Forms.MaskedTextBox();
            this.txt_thanhTienTonDau = new System.Windows.Forms.TextBox();
            this.txt_soLuongTonDau = new System.Windows.Forms.TextBox();
            this.txt_donViTinh = new System.Windows.Forms.TextBox();
            this.txt_nhomHH = new System.Windows.Forms.TextBox();
            this.txt_tenHH = new System.Windows.Forms.TextBox();
            this.txt_maHH = new System.Windows.Forms.TextBox();
            this.btnInDS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_xoa_HangHoa
            // 
            this.btn_xoa_HangHoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_xoa_HangHoa.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa_HangHoa.Location = new System.Drawing.Point(663, 596);
            this.btn_xoa_HangHoa.Name = "btn_xoa_HangHoa";
            this.btn_xoa_HangHoa.Size = new System.Drawing.Size(130, 43);
            this.btn_xoa_HangHoa.TabIndex = 11;
            this.btn_xoa_HangHoa.Text = "Xóa";
            this.btn_xoa_HangHoa.UseVisualStyleBackColor = false;
            this.btn_xoa_HangHoa.Click += new System.EventHandler(this.btn_xoa_HangHoa_Click);
            // 
            // btn_sua_HangHoa
            // 
            this.btn_sua_HangHoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_sua_HangHoa.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua_HangHoa.Location = new System.Drawing.Point(504, 596);
            this.btn_sua_HangHoa.Name = "btn_sua_HangHoa";
            this.btn_sua_HangHoa.Size = new System.Drawing.Size(130, 43);
            this.btn_sua_HangHoa.TabIndex = 12;
            this.btn_sua_HangHoa.Text = "Sửa";
            this.btn_sua_HangHoa.UseVisualStyleBackColor = false;
            this.btn_sua_HangHoa.Click += new System.EventHandler(this.btn_sua_HangHoa_Click);
            // 
            // btn_them_HangHoa
            // 
            this.btn_them_HangHoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_them_HangHoa.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them_HangHoa.Location = new System.Drawing.Point(340, 596);
            this.btn_them_HangHoa.Name = "btn_them_HangHoa";
            this.btn_them_HangHoa.Size = new System.Drawing.Size(130, 43);
            this.btn_them_HangHoa.TabIndex = 13;
            this.btn_them_HangHoa.Text = "Thêm";
            this.btn_them_HangHoa.UseVisualStyleBackColor = false;
            this.btn_them_HangHoa.Click += new System.EventHandler(this.btn_them_HangHoa_Click);
            // 
            // HangHoaGridView
            // 
            this.HangHoaGridView.AllowUserToAddRows = false;
            this.HangHoaGridView.AllowUserToDeleteRows = false;
            this.HangHoaGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HangHoaGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.HangHoaGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HangHoaGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.HangHoaGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.HangHoaGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HangHoaGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.HangHoaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HangHoaGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.HangHoaGridView.EnableHeadersVisualStyles = false;
            this.HangHoaGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HangHoaGridView.Location = new System.Drawing.Point(80, 178);
            this.HangHoaGridView.MultiSelect = false;
            this.HangHoaGridView.Name = "HangHoaGridView";
            this.HangHoaGridView.ReadOnly = true;
            this.HangHoaGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.HangHoaGridView.RowHeadersVisible = false;
            this.HangHoaGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.HangHoaGridView.RowTemplate.Height = 24;
            this.HangHoaGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HangHoaGridView.Size = new System.Drawing.Size(1178, 376);
            this.HangHoaGridView.TabIndex = 4;
            this.HangHoaGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HangHoaGridView_CellClick);
            // 
            // btn_dung
            // 
            this.btn_dung.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_dung.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dung.Location = new System.Drawing.Point(828, 596);
            this.btn_dung.Name = "btn_dung";
            this.btn_dung.Size = new System.Drawing.Size(120, 43);
            this.btn_dung.TabIndex = 15;
            this.btn_dung.Text = "Dừng";
            this.btn_dung.UseVisualStyleBackColor = false;
            this.btn_dung.Click += new System.EventHandler(this.btn_dung_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(901, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 38;
            this.label6.Text = "Đơn vị tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(637, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 24);
            this.label7.TabIndex = 37;
            this.label7.Text = "Thành tiền tồn đầu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(637, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 24);
            this.label8.TabIndex = 36;
            this.label8.Text = "Số lượng tồn đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nhóm hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ngày tồn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tên hàng hóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mã hàng hóa";
            // 
            // mboxNgayTon
            // 
            this.mboxNgayTon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mboxNgayTon.Location = new System.Drawing.Point(360, 48);
            this.mboxNgayTon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mboxNgayTon.Mask = "00/00/0000";
            this.mboxNgayTon.Name = "mboxNgayTon";
            this.mboxNgayTon.Size = new System.Drawing.Size(196, 30);
            this.mboxNgayTon.TabIndex = 31;
            this.mboxNgayTon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_thanhTienTonDau
            // 
            this.txt_thanhTienTonDau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thanhTienTonDau.Location = new System.Drawing.Point(633, 120);
            this.txt_thanhTienTonDau.Name = "txt_thanhTienTonDau";
            this.txt_thanhTienTonDau.Size = new System.Drawing.Size(196, 30);
            this.txt_thanhTienTonDau.TabIndex = 25;
            // 
            // txt_soLuongTonDau
            // 
            this.txt_soLuongTonDau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soLuongTonDau.Location = new System.Drawing.Point(633, 48);
            this.txt_soLuongTonDau.Name = "txt_soLuongTonDau";
            this.txt_soLuongTonDau.Size = new System.Drawing.Size(196, 30);
            this.txt_soLuongTonDau.TabIndex = 26;
            // 
            // txt_donViTinh
            // 
            this.txt_donViTinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_donViTinh.Location = new System.Drawing.Point(901, 48);
            this.txt_donViTinh.Name = "txt_donViTinh";
            this.txt_donViTinh.Size = new System.Drawing.Size(196, 30);
            this.txt_donViTinh.TabIndex = 27;
            // 
            // txt_nhomHH
            // 
            this.txt_nhomHH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhomHH.Location = new System.Drawing.Point(360, 121);
            this.txt_nhomHH.Name = "txt_nhomHH";
            this.txt_nhomHH.Size = new System.Drawing.Size(196, 30);
            this.txt_nhomHH.TabIndex = 28;
            // 
            // txt_tenHH
            // 
            this.txt_tenHH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenHH.Location = new System.Drawing.Point(100, 121);
            this.txt_tenHH.Name = "txt_tenHH";
            this.txt_tenHH.Size = new System.Drawing.Size(196, 30);
            this.txt_tenHH.TabIndex = 29;
            // 
            // txt_maHH
            // 
            this.txt_maHH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maHH.Location = new System.Drawing.Point(100, 48);
            this.txt_maHH.Name = "txt_maHH";
            this.txt_maHH.Size = new System.Drawing.Size(196, 30);
            this.txt_maHH.TabIndex = 30;
            // 
            // btnInDS
            // 
            this.btnInDS.BackColor = System.Drawing.Color.DarkGray;
            this.btnInDS.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDS.Location = new System.Drawing.Point(901, 115);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(195, 37);
            this.btnInDS.TabIndex = 39;
            this.btnInDS.Text = "In Danh Sách Hàng Hóa";
            this.btnInDS.UseVisualStyleBackColor = false;
            this.btnInDS.Click += new System.EventHandler(this.btnInDS_Click);
            // 
            // FormHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 638);
            this.Controls.Add(this.btnInDS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mboxNgayTon);
            this.Controls.Add(this.txt_thanhTienTonDau);
            this.Controls.Add(this.txt_soLuongTonDau);
            this.Controls.Add(this.txt_donViTinh);
            this.Controls.Add(this.txt_nhomHH);
            this.Controls.Add(this.txt_tenHH);
            this.Controls.Add(this.txt_maHH);
            this.Controls.Add(this.btn_dung);
            this.Controls.Add(this.btn_xoa_HangHoa);
            this.Controls.Add(this.btn_sua_HangHoa);
            this.Controls.Add(this.btn_them_HangHoa);
            this.Controls.Add(this.HangHoaGridView);
            this.Name = "FormHangHoa";
            this.Text = "FromHangHoa";
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            this.MouseEnter += new System.EventHandler(this.FormHangHoa_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FormHangHoa_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_xoa_HangHoa;
        private System.Windows.Forms.Button btn_sua_HangHoa;
        private System.Windows.Forms.Button btn_them_HangHoa;
        private System.Windows.Forms.DataGridView HangHoaGridView;
        private System.Windows.Forms.Button btn_dung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mboxNgayTon;
        private System.Windows.Forms.TextBox txt_thanhTienTonDau;
        private System.Windows.Forms.TextBox txt_soLuongTonDau;
        private System.Windows.Forms.TextBox txt_donViTinh;
        private System.Windows.Forms.TextBox txt_nhomHH;
        private System.Windows.Forms.TextBox txt_tenHH;
        private System.Windows.Forms.TextBox txt_maHH;
        private System.Windows.Forms.Button btnInDS;
    }
}