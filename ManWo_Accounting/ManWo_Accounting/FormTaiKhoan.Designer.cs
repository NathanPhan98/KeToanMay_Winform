
namespace ManWo_Accounting
{
    partial class FormTaiKhoan
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
            this.HangHoaGridView = new System.Windows.Forms.DataGridView();
            this.btnInDS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaGridView)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HangHoaGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.HangHoaGridView.EnableHeadersVisualStyles = false;
            this.HangHoaGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HangHoaGridView.Location = new System.Drawing.Point(20, 138);
            this.HangHoaGridView.MultiSelect = false;
            this.HangHoaGridView.Name = "HangHoaGridView";
            this.HangHoaGridView.ReadOnly = true;
            this.HangHoaGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.HangHoaGridView.RowHeadersVisible = false;
            this.HangHoaGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.HangHoaGridView.RowTemplate.Height = 24;
            this.HangHoaGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HangHoaGridView.Size = new System.Drawing.Size(1092, 388);
            this.HangHoaGridView.TabIndex = 5;
            this.HangHoaGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HangHoaGridView_CellContentClick);
            // 
            // btnInDS
            // 
            this.btnInDS.BackColor = System.Drawing.Color.DarkGray;
            this.btnInDS.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDS.Location = new System.Drawing.Point(917, 69);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(195, 37);
            this.btnInDS.TabIndex = 44;
            this.btnInDS.Text = "In Danh Sách Tài Khoản";
            this.btnInDS.UseVisualStyleBackColor = false;
            this.btnInDS.Click += new System.EventHandler(this.btnInDS_Click);
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 619);
            this.Controls.Add(this.btnInDS);
            this.Controls.Add(this.HangHoaGridView);
            this.Name = "FormTaiKhoan";
            this.Text = "FormTaiKhoan";
            this.Load += new System.EventHandler(this.FormTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HangHoaGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView HangHoaGridView;
        private System.Windows.Forms.Button btnInDS;
    }
}