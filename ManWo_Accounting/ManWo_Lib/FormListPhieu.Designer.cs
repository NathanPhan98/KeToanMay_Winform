
namespace ManWo_Accounting
{
    partial class FormListPhieu
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
            this.dgvDSPhieu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSPhieu
            // 
            this.dgvDSPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSPhieu.Location = new System.Drawing.Point(0, 0);
            this.dgvDSPhieu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDSPhieu.Name = "dgvDSPhieu";
            this.dgvDSPhieu.RowHeadersWidth = 51;
            this.dgvDSPhieu.RowTemplate.Height = 24;
            this.dgvDSPhieu.Size = new System.Drawing.Size(800, 450);
            this.dgvDSPhieu.TabIndex = 1;
            this.dgvDSPhieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPhieu_CellClick);
            this.dgvDSPhieu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDSPhieu_KeyDown);
            // 
            // FormListPhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDSPhieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormListPhieu";
            this.Text = "Danh sách phiếu";
            this.Load += new System.EventHandler(this.FormListPhieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSPhieu;
    }
}