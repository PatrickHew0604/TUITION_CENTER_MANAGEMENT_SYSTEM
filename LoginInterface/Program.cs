using LoginInterface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginInterface
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //DBConnection con = new DBConnection();
            //con.EstablishConnection();
            //SqlDataReader drd = con.DataReader("SELECT * FROM receptionist WHERE username = 'tes'");
            //while (drd.Read())
            //{
            //    Application.Run(new OwnProfile(drd["username"].ToString(), drd["password"].ToString(), drd["name"].ToString(), drd["ic_passport"].ToString(), drd["email"].ToString(), drd["contact_num"].ToString(), drd["address"].ToString(), drd["gender"].ToString()));

            //}
            Application.Run(new LoginForm());
        } 
    }
}
