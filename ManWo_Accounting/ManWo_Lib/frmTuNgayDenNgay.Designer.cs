
namespace ManWo_Accounting
{
    partial class frmTuNgayDenNgay
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.mboxDenNgay = new System.Windows.Forms.MaskedTextBox();
            this.mboxTuNgay = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNhapTuDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAccept.Location = new System.Drawing.Point(227, 133);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(94, 37);
            this.btnAccept.TabIndex = 25;
            this.btnAccept.Text = "&Chấp nhận";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // mboxDenNgay
            // 
            this.mboxDenNgay.Location = new System.Drawing.Point(392, 73);
            this.mboxDenNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mboxDenNgay.Mask = "00/00/0000";
            this.mboxDenNgay.Name = "mboxDenNgay";
            this.mboxDenNgay.Size = new System.Drawing.Size(116, 22);
            this.mboxDenNgay.TabIndex = 24;
            this.mboxDenNgay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mboxTuNgay
            // 
            this.mboxTuNgay.Location = new System.Drawing.Point(126, 74);
            this.mboxTuNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mboxTuNgay.Mask = "00/00/0000";
            this.mboxTuNgay.Name = "mboxTuNgay";
            this.mboxTuNgay.Size = new System.Drawing.Size(116, 22);
            this.mboxTuNgay.TabIndex = 23;
            this.mboxTuNgay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Từ ngày";
            // 
            // btnNhapTuDong
            // 
            this.btnNhapTuDong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNhapTuDong.Location = new System.Drawing.Point(227, 13);
            this.btnNhapTuDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhapTuDong.Name = "btnNhapTuDong";
            this.btnNhapTuDong.Size = new System.Drawing.Size(94, 37);
            this.btnNhapTuDong.TabIndex = 29;
            this.btnNhapTuDong.Text = "&Nhap tu dong";
            this.btnNhapTuDong.UseVisualStyleBackColor = false;
            this.btnNhapTuDong.Visible = false;
            this.btnNhapTuDong.Click += new System.EventHandler(this.btnNhapTuDong_Click);
            // 
            // frmTuNgayDenNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 207);
            this.Controls.Add(this.btnNhapTuDong);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.mboxDenNgay);
            this.Controls.Add(this.mboxTuNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTuNgayDenNgay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Từ ngày đến ngày";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.MaskedTextBox mboxDenNgay;
        private System.Windows.Forms.MaskedTextBox mboxTuNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNhapTuDong;
    }
}