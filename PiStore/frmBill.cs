using DevExpress.XtraEditors;
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
    public partial class frmBill : Form
    {
        DataTable dtBill = new DataTable();
        public frmBill()
        {
            InitializeComponent();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            dtBill = Program.Load_DataTable("Select * From __BILL");
            gridBill.DataSource = dtBill;
            gridView1.OptionsBehavior.Editable = false;
        }

        private void btnPrintBill_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtBill.Rows.Count > 0)
            {
                if (XtraMessageBox.Show("Do you want to print this bill ?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    Int32 row = gridView1.GetSelectedRows()[0];
                    string bill_id = dtBill.Rows[row]["bill_id"].ToString();
                    Program.reportId = bill_id;

                    ReportForm report = new ReportForm();
                    report.Show();
                }
            }
        }
    }
}
