using System;
using System.Data;
using System.Windows.Forms;

namespace PiStore
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login()
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password", "Message");
            }
            else
            {
                DataTable dt = Program.Load_DataTable("Select * From __Account Where acc_id = '" + username + "'");
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0]; 
                    if (row["password"].ToString() == password)
                    {
                        Program.session_empId = row["emp_id"].ToString();
                        frmMain main = new frmMain();
                        this.Hide();
                        main.ShowDialog();
                    }
                    else
                    {
                        txtPassword.Text = "";
                        MessageBox.Show("Wrong username or password", "Message");
                    }
                }else
                {
                    MessageBox.Show("Account not exist");
                }
            }
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                Login();
                
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.KeyDown += new KeyEventHandler(tb_KeyDown);
        }
    }
}