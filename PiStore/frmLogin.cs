using System;
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
                if (username == "admin" && password == "9952811")
                {
                    frmMain main = new frmMain();
                    this.Hide();
                    main.ShowDialog();
                }
                else
                {
                    txtPassword.Text = "";
                    MessageBox.Show("Wrong username or password", "Message");
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