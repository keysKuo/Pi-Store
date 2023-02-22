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
    public partial class frmOrder : Form
    {
        DataTable dtProduct = new DataTable();
        DataTable dtClient = new DataTable();
        DataTable dtPlaceOrder = new DataTable();
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            setUpGridPlaceOrder();
            refreshData();
            gridViewProduct.OptionsBehavior.Editable = false;
            gridViewClient.OptionsBehavior.Editable = false;
            gridViewPlaceOrder.OptionsBehavior.Editable = false;
            
        }

        private void setUpGridPlaceOrder()
        {
            dtPlaceOrder.Columns.Add("pid", typeof(String));
            dtPlaceOrder.Columns.Add("name", typeof(String));
            dtPlaceOrder.Columns.Add("price", typeof(int));
            dtPlaceOrder.Columns.Add("quantity", typeof(int));
            
        }

        private void refreshData()
        {
            dtProduct = Program.Load_DataTable("Select * From __Product");
            dtClient = Program.Load_DataTable("Select * From __Client");
            
            gridProduct.DataSource = dtProduct;
            gridClient.DataSource = dtClient;
            gridPlaceOrder.DataSource = dtPlaceOrder;
            

        }

        private void btnSelectProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 row = gridViewProduct.GetSelectedRows()[0];
            String pid = dtProduct.Rows[row]["pid"].ToString();
            String name = dtProduct.Rows[row]["name"].ToString();
            int price = Int32.Parse(dtProduct.Rows[row]["price"].ToString());
            int quantity = Int32.Parse(dtProduct.Rows[row]["quantity"].ToString());
            
            XtraInputBoxArgs args = new XtraInputBoxArgs();
            args.Caption = "Enter number of products";
            args.Prompt = "Quantity";
            //args.Editor = new PageNumberEdit();
            args.DefaultResponse = 1;
            bool cancelClicked = false;
            args.Showing += (s, eventArgs) => {
                eventArgs.Buttons[DialogResult.Cancel].Click += (btn, btnEventArgs) => {
                    cancelClicked = true;
                };
            };

            var value = XtraInputBox.Show(args);
            int cap = Convert.ToInt32(value);
            if (cancelClicked)
            {
                XtraMessageBox.Show("Cancel Button Clicked");
            }
            else
            {
                foreach(DataRow r in dtPlaceOrder.Rows) {
                    if(r["pid"].ToString() == pid)
                    {
                        MessageBox.Show("Product has been in order already");
                        return;
                    }

                }


                if (cap > quantity)
                {
                    MessageBox.Show("Capacity is not enough");
                    return;
                }

                dtPlaceOrder.Rows.Add(pid, name, price, value);
                gridPlaceOrder.DataSource = dtPlaceOrder;
                
            }
        }
    }
}
