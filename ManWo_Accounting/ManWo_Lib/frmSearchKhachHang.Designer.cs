
namespace ManWo_Accounting
{
    partial class frmSearchKhachHang
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
            this.txt_info_khachhang = new System.Windows.Forms.TextBox();
            this.btn_search_khachhhang = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblSlash = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_info_khachhang
            // 
            this.txt_info_khachhang.Location = new System.Drawing.Point(29, 12);
            this.txt_info_khachhang.Multiline = true;
            this.txt_info_khachhang.Name = "txt_info_khachhang";
            this.txt_info_khachhang.Size = new System.Drawing.Size(524, 40);
            this.txt_info_khachhang.TabIndex = 0;
            // 
            // btn_search_khachhhang
            // 
            this.btn_search_khachhhang.Location = new System.Drawing.Point(213, 63);
            this.btn_search_khachhhang.Name = "btn_search_khachhhang";
            this.btn_search_khachhhang.Size = new System.Drawing.Size(142, 45);
            this.btn_search_khachhhang.TabIndex = 1;
            this.btn_search_khachhhang.Text = "Tìm";
            this.btn_search_khachhhang.UseVisualStyleBackColor = true;
            this.btn_search_khachhhang.Click += new System.EventHandler(this.btn_search_khachhhang_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(674, 13);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 39);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Lên";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(674, 67);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 39);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Xuống";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(606, 24);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(0, 17);
            this.lblItems.TabIndex = 4;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(570, 24);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(46, 16);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "label1";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(622, 24);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(46, 16);
            this.lblItem.TabIndex = 6;
            this.lblItem.Text = "label2";
            // 
            // lblSlash
            // 
            this.lblSlash.AutoSize = true;
            this.lblSlash.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlash.Location = new System.Drawing.Point(606, 24);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(14, 19);
            this.lblSlash.TabIndex = 7;
            this.lblSlash.Text = "/";
            // 
            // frmSearchKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 120);
            this.Controls.Add(this.lblSlash);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btn_search_khachhhang);
            this.Controls.Add(this.txt_info_khachhang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSearchKhachHang";
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.frmSearchKhachHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_info_khachhang;
        private System.Windows.Forms.Button btn_search_khachhhang;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblSlash;
    }
}