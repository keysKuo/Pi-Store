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
        DataTable dtOrderList = new DataTable();
        DataTable dtDetail = new DataTable();
        DateTime now = DateTime.UtcNow.Date;
        int total = 0;
        String chosenTime = "";

        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            dateOrderList.DateTime = now;
            if (dtPlaceOrder.Rows.Count == 0)
            {
                setUpGridPlaceOrder();
            }

            if (dtOrderList.Rows.Count == 0)
            {
                setUpGridOrderList();
            }
            refreshData();

            gridViewProduct.OptionsBehavior.Editable = false;
            gridViewClient.OptionsBehavior.Editable = false;
            gridViewPlaceOrder.OptionsBehavior.Editable = false;
            gridViewOrderList.OptionsBehavior.Editable = false;
            gridViewDetail.OptionsBehavior.Editable = false;
        }

        private void setUpGridOrderList()
        {
            dtOrderList.Columns.Add("order_id", typeof(String));
            dtOrderList.Columns.Add("client_name", typeof(String));
            dtOrderList.Columns.Add("phone", typeof(String));
            dtOrderList.Columns.Add("total", typeof(String));
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
            chosenTime = now.ToString("yyyy-MM-dd");
            dtProduct = Program.Load_DataTable("Select * From __Product");
            dtClient = Program.Load_DataTable("Select * From __Client");
            dtOrderList = Program.Load_DataTable("Select O.order_id, C.client_id, C.name as client_name, C.phone, O.total "
                + "From __Order O, __Client C Where O.client_id = C.client_id And O.orderDate = '" + chosenTime + "'"
                );

            gridProduct.DataSource = dtProduct;
            gridClient.DataSource = dtClient;
            gridPlaceOrder.DataSource = dtPlaceOrder;
            gridOrderList.DataSource = dtOrderList;
            
        }

        private void reQueryOrderListByDate()
        {
            chosenTime = dateOrderList.DateTime.ToString("yyyy-MM-dd");
            dtOrderList = Program.Load_DataTable("Select O.order_id, C.client_id, C.name as client_name, C.phone, O.total "
                + "From __Order O, __Client C Where O.client_id = C.client_id And O.orderDate = '" + chosenTime + "'"
                );
            gridOrderList.DataSource = dtOrderList;
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
                // Cancelled
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

                dtPlaceOrder.Rows.Add(pid, name, price, cap);
                total += (price * cap);
                lblTotalValue.Text = total.ToString() + "$";
                gridPlaceOrder.DataSource = dtPlaceOrder;
                
            }
        }

        private void btnDelPlaceOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 row = gridViewPlaceOrder.GetSelectedRows()[0];
            dtPlaceOrder.Rows.RemoveAt(row);
        }

        private void btnClearOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dtPlaceOrder.Rows.Clear();
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if(dtPlaceOrder.Rows.Count == 0)
            {
                XtraMessageBox.Show("Please select products before placing order");
                return;
            }

            

            if (XtraMessageBox.Show("Do you want to create the order ?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                Int32 cli_row = gridViewClient.GetSelectedRows()[0];
                String client_id = dtClient.Rows[cli_row][0].ToString();
                String emp_id = Program.session_empId;
                String order_id = "OD" + Program.RandomString(8);
                
                Program.Execute("Insert into __Order values ("
                    + Program.strQuery(order_id) + ","
                    + Program.strQuery(client_id) + ","
                    + Program.strQuery(emp_id) + ","
                    + "GETDATE()" + ","
                    + total.ToString() + ")"
                    );
                
                foreach (DataRow row in dtPlaceOrder.Rows)
                {
                    String pid = row["pid"].ToString();
                    String OI_id = "OI" + Program.RandomString(8);
                    int quantity = Int32.Parse(row["quantity"].ToString());

                    Program.Execute("Insert into __OrderItem values ("
                        + Program.strQuery(OI_id) + ","
                        + Program.strQuery(order_id) + ","
                        + Program.strQuery(pid) + ","
                        + quantity.ToString() + ")"
                        );
                }

                dtPlaceOrder.Rows.Clear();
                refreshData();

                XtraMessageBox.Show("Place order successfully");
                return;
            }
        }

        private void gridViewOrderList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(dtOrderList.Rows.Count > 0)
            {
                Int32 order_row = gridViewOrderList.GetSelectedRows()[0];
                String order_id = dtOrderList.Rows[order_row]["order_id"].ToString();
                dtDetail = Program.Load_DataTable("Select P.pid, P.name, P.price, P.quantity From __OrderItem OI, __Product P Where OI.pid = P.pid AND OI.order_id = " + Program.strQuery(order_id));
                gridDetail.DataSource = dtDetail;
                lblDetailTotal.Text = dtOrderList.Rows[order_row]["total"].ToString() + "$";
            }else
            {
                dtDetail.Rows.Clear();
                lblDetailTotal.Text = "0$";
            }
            
        }

        private void btnExportBill_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to export bill ?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                
            }
        }

        private void dateOrderList_EditValueChanged(object sender, EventArgs e)
        {
            reQueryOrderListByDate();
        }
    }
}
