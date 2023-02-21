using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

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
    }
}
