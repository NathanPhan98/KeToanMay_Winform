using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManWo_Accounting.report
{
    public partial class frmPeportPhieuNhap : Form
    {
        public frmPeportPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmPeportPhieuNhap_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
