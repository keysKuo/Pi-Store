using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmEmployee : Form
    {
        DataTable dt = new DataTable();
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            renderGrid();
        }

        private void renderGrid()
        {
            dt = Program.Load_DataTable("Select * From __Employee");
            dt.PrimaryKey = new DataColumn[] { dt.Columns["emp_id"] };

            gridEmployee.DataSource = dt;
        }

        private void updateEmployee(String emp_id, String name, String email, String phone, String address, int salary, String hireDate)
        {
            Program.Execute("Update __EMPLOYEE SET "
                + "name = " + Program.strQuery(name) + ","
                + "email = " + Program.strQuery(email) + ","
                + "phone = " + Program.strQuery(phone) + ","
                + "address = " + Program.strQuery(address) + ","
                + "salary = " + salary.ToString() + ","
                + "hireDate = " + Program.strQuery(hireDate)
                + " Where emp_id = " + Program.strQuery(emp_id)
            );

            refreshData();
        }

        private void addEmployee(String emp_id, String name, String email, String phone, String address, int salary, String hireDate)
        {
            Program.Execute("Insert into __EMPLOYEE values ("
                + Program.strQuery(emp_id) + ","
                + Program.strQuery(name) + ","
                + Program.strQuery(email) + ","
                + Program.strQuery(phone) + ","
                + Program.strQuery(address) + ","
                + salary.ToString() + ","
                + Program.strQuery(hireDate) + ")"
            );

            refreshData();
        }

        private void deleteEmployee(String emp_id)
        {
            Program.Execute("Delete From __EMPLOYEE Where emp_id = " + Program.strQuery(emp_id));
            refreshData();
        }

        private void refreshData()
        {
            renderGrid();
        }

        private void btnAddEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        private void btnDeleteEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                Int32 row = gridView1.GetSelectedRows()[0];
                if (row >= 0)
                {
                    string emp_id = dt.Rows[row][0].ToString();

                    if (XtraMessageBox.Show("Do you want to remove empoyee " + emp_id + " ?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
                    {
                        deleteEmployee(emp_id);
                        MessageBox.Show("Employee - " + emp_id + " removed");
                    }
                }      
            }
        }

        private void btnSaveEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    String emp_id = row[0].ToString();
                    String name = row[1].ToString();
                    String email = row[2].ToString();
                    String phone = row[3].ToString();
                    String address = row[4].ToString();
                    int salary = Int32.Parse(row[5].ToString());
                    String hireDate = Program.transDate(row[6].ToString());

                    if (emp_id.Length > 10)
                    {
                        MessageBox.Show("Emp_id cannot be longer than 10 characters", emp_id);
                        return;
                    }

                    if (!Program.IsValidEmail(email))
                    {
                        MessageBox.Show("Email invalid", emp_id);
                        return;
                    }

                    if (phone.Length > 10)
                    {
                        MessageBox.Show("Phone only contain 10 numbers", emp_id);
                        return;
                    }

                    if (emp_id != "")
                    {
                        if (Program.isExist("Select emp_id FROM __Employee Where emp_id = " + Program.strQuery(emp_id)))
                        {
                            updateEmployee(emp_id, name, email, phone, address, salary, hireDate);

                        }
                        else
                        {
                            addEmployee(emp_id, name, email, phone, address, salary, hireDate); 

                        }
                    }
                }

                MessageBox.Show("Save successfully");
            }
        }

        private void btnRefreshEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            refreshData();
            MessageBox.Show("Refresh successfully");
        }
        private void autoGenerateEmployee()
        {
            for (int i = 1; i <= 20; i++)
            {
                String client_id = "EMP" + normalizeNumber(i);
                String name = "Employee " + i;
                String email = "employee" + i + "@gmail.com";
                String phone = "0929852953";
                String address = "...";
                addEmployee(client_id, name, email, phone, address, 10000000, "2023-02-05");
            }

            refreshData();
        }

        private string normalizeNumber(int num)
        {
            if (num >= 1000)
            {
                return num.ToString();
            }
            else if (num >= 100)
            {
                return "0" + num.ToString();
            }
            else if (num >= 10)
            {
                return "00" + num.ToString();
            }
            else
            {
                return "000" + num.ToString();
            }
        }

        private void btnAutoGenerateEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            autoGenerateEmployee();
        }

        private void btnRemoveAllEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure that you want to remove all employees ?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                Program.Execute("Delete From __Employee");
                
                refreshData();
            }
        }
    }
}
