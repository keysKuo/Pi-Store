using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiStore
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            DataTable dt = Program.Load_DataTable(
                "Select P.pid, P.name as p_name, P.price, OI.quantity, B.billDate as createdAt, B.total, B.emp_id as acc_id " +
                "From __OrderItem OI, __Product P, __BILL B " +
                "Where P.pid = OI.pid And B.order_id = OI.order_id And B.bill_id = '" + Program.reportId + "'" );
            var source = new ReportDataSource("ImportDataSet", dt);
            reportViewer1.LocalReport.ReportPath = "../../Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
    }
}
