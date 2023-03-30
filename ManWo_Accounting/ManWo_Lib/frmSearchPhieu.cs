using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using ManWo_Lib;

namespace ManWo_Accounting
{
    public partial class frmSearchPhieu : Form
    {
        
        public frmSearchPhieu()
        {
            InitializeComponent();
        }
        
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            AppEnv.searchValue = textBox1.Text;
        }

        private void frmSearchPhieu_Load(object sender, EventArgs e)
        {

        }
    }
}
