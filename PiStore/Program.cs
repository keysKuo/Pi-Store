using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DevExpress.XtraDashboardLayout;

namespace PiStore
{
    internal static class Program
    {
        public static string strConn = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }

        public static DataTable Load_DataTable(string query)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            if (da != null)
            {
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
            }

            return new DataTable();
        }

        public static bool isExist(string query)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            if (da != null)
            {
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static void Execute(string query)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static string strQuery(string s)
        {
            return "'" + s + "'";
        }

        public static string transDate(string date)
        {   
            string[] part = date.Split('/');
            int month = Int32.Parse(part[0]);
            int day = Int32.Parse(part[1]);

            string strMonth = month >= 10 ? part[0] : "0" + part[0];
            string strDay = day > 10 ? part[1] : "0" + part[1];
            return part[2].Split(' ')[0] + "-" + strMonth + "-" + strDay;
        }

        public static bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    }
}
