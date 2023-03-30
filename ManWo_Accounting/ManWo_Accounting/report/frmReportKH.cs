using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using ManWo_Lib;

namespace ManWo_Accounting.report
{
    public partial class frmReportKH : Form
    {
        public frmReportKH()
        {
            InitializeComponent();
        }

        private void frmReportNV_Load(object sender, EventArgs e)
        {
            string sql = "select * from tDanhMucKhachHang";
            DataSet ds;
            ds = AppEnv.ReadDataSet(sql);

            this.reportViewer1.LocalReport.ReportEmbeddedResource =
                "ManWo_Accounting.ReportKH.rdlc";

            ReportDataSource rds = new ReportDataSource();

            rds.Name = "DataSetKH";
            rds.Value = ds.Tables[0];
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
