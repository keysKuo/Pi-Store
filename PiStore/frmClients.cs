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
    public partial class frmClients : Form
    {
        DataTable dt = new DataTable();
        public frmClients()
        {
            InitializeComponent();
        }

        private void frmClients_Load(object sender, EventArgs e)
        {
            renderGrid();
        }

        private void renderGrid()
        {
            dt = Program.Load_DataTable("Select * From __Client");
            dt.PrimaryKey = new DataColumn[] { dt.Columns["client_id"] };
            
            gridClient.DataSource = dt;
        }

        private void autoGenerateClient()
        {
            for (int i = 1; i <= 20; i++)
            {
                String client_id = "CL" + normalizeNumber(i);
                String name = "Client " + i;
                String email = "client" + i + "@gmail.com";
                String phone = "0767916592";
                String address = "Somewhere in the world";
                addClient(client_id, name, email, phone, address);
            }

            refreshData();
        }

        private string normalizeNumber(int num)
        {
            if (num >= 100)
            {
                return num.ToString();
            }
            else if (num >= 10)
            {
                return "0" + num.ToString();
            }
            else
            {
                return "00" + num.ToString();
            }
        }

        private void addClient(String client_id, String name, String email, String phone, String address)
        {
            Program.Execute("Insert into __CLIENT values ("
                + Program.strQuery(client_id) + ","
                + Program.strQuery(name) + ","
                + Program.strQuery(email) + ","
                + Program.strQuery(phone) + ","
                + Program.strQuery(address) + ")"
            );

            refreshData();
        }

        private void updateClient(String client_id, String name, String email, String phone, String address)
        {
            Program.Execute("Update __CLIENT SET "
                + "name = " + Program.strQuery(name) + ","
                + "email = " + Program.strQuery(email) + ","
                + "phone = " + Program.strQuery(phone) + ","
                + "address = " + Program.strQuery(address) + ","
                + " Where client_id = " + Program.strQuery(client_id)
            );

            refreshData();
        }

        private void refreshData()
        {
            renderGrid();
        }

        private void btnAutoGenerateClient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(dt.Rows.Count == 0)
            {
                if (XtraMessageBox.Show("Do you want to auto generate records" + " ?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    autoGenerateClient();
                }
            }
            else
            {
                MessageBox.Show("Records available");
            }
        }

        

        private void btnAddClient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        private void btnSaveClient_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    String client_id = row[0].ToString();
                    String name = row[1].ToString();
                    String email = row[2].ToString();
                    String phone = row[3].ToString();
                    String address = row[4].ToString();

                    if (client_id != "")
                    {
                        if (Program.isExist("Select client_id FROM __CLIENT Where client_id = " + Program.strQuery(client_id)))
                        {
                            updateClient(client_id, name, email, phone, address);

                        }
                        else
                        {
                            addClient(client_id, name, email, phone, address);

                        }
                    }
                }

                MessageBox.Show("Save successfully");
            }
        }
    }
}
