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
    public partial class frmProduct : Form
    {
        DataTable dtProduct = new DataTable();
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            renderGridProduct();
        }

        private void renderGridProduct()
        {
            dtProduct = Program.Load_DataTable("Select * From __Product");
            dtProduct.PrimaryKey = new DataColumn[] { dtProduct.Columns["pid"] };

            gridProduct.DataSource = dtProduct;
        }

        private void btnAddProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }

        private void btnRemoveProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtProduct.Rows.Count > 0)
            {
                Int32 row = gridView1.GetSelectedRows()[0];
                string pid = dtProduct.Rows[row][0].ToString();

                if (XtraMessageBox.Show("Do you want to remove product " + pid + " ?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    Program.Execute("Delete From __Product Where pid = " + Program.strQuery(pid));
                    MessageBox.Show("Product - " + pid + " removed");
                    renderGridProduct();
                }
            }
        }

        private void btnSaveProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtProduct.Rows.Count > 0)
            {
                foreach (DataRow row in dtProduct.Rows)
                {
                    String pid = row["pid"].ToString();
                    String name = row["name"].ToString();
                    String description = row["description"].ToString();
                    int price = Int32.Parse(row["price"].ToString());
                    int quantity = Int32.Parse(row["quantity"].ToString());
                   
                    if (pid != "")
                    {
                        if (Program.isExist("Select pid FROM __PRODUCT Where pid = " + Program.strQuery(pid)))
                        {
                            updateProduct(pid, name, description, price, quantity);
                            
                        }
                        else
                        {    
                            addProduct(pid, name, description, price, quantity);

                        }
                    }
                }

                MessageBox.Show("Save successfully");
            }
        }

        private void updateProduct(String pid, String name, String description, int price, int quantity)
        {
            Program.Execute("Update __PRODUCT SET "
                + "name = " + Program.strQuery(name) + ","
                + "description = " + Program.strQuery(description) + ","
                + "price = " + price.ToString() + ","
                + "quantity = " + quantity.ToString()
                + " Where pid = " + Program.strQuery(pid)    
            );

            refreshData();
        }

        private void addProduct(String pid, String name, String description, int price, int quantity)
        {
            Program.Execute("Insert into __PRODUCT values ("
                + Program.strQuery(pid) + ","
                + Program.strQuery(name) + ","
                + Program.strQuery(description) + ","
                + price.ToString() + "," 
                + quantity.ToString() + ")"
            );

            refreshData();
        }

        private void refreshData()
        {
            renderGridProduct();
        }

        private void btnRefreshProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            refreshData();
            MessageBox.Show("Refresh successfully");
        }
    }
}
