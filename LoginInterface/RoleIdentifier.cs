using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;


namespace LoginInterface
{
    internal class RoleIdentifier
    {
        private string role;
        private string username;
        private string password;

        public RoleIdentifier(string username,string password)
        {
            this.username = username;
            this.password = password;
        }
        public string RoleOfUser()
        {
            Dictionary<string, string> accInfo = new Dictionary<string, string>();
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            SqlDataReader rd = con.DataReader
                ("SELECT username,password,('Student') AS role FROM student UNION SELECT username,password,role FROM staff");
            while (rd.Read())
            {
                // Used to keep all the account info in a dictionary for username and password matching
                accInfo.Add(rd["username"].ToString(), rd["password"].ToString());
            }
            rd.Close();
            if (accInfo.ContainsKey(this.username))
            {
                if (accInfo[this.username] == this.password)
                {
                    this.role = con.RetrieveData
                        ($"SELECT role FROM role_identifier WHERE username='{this.username}' AND password = '{this.password}'").ToString();
                    UpdateLastOnline(this.role, this.username, this.password);
                    con.Close();
                    return role;
                }
                else
                {
                    return "NULL";
                }
            }
            else
            {
                return "NULL";
            }
        }
        public void UpdateLastOnline(string role,string username,string password)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            if (role == "Tutor" || role == "Admin" || role == "Receptionist")
                con.UpdateData
                    ($"UPDATE staff SET last_online = '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE username = '{username}' AND password = '{password}'");
            else
                con.UpdateData
                    ($"UPDATE student SET last_online = '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' WHERE username = '{username}' AND password = '{password}'");
            con.Close();
        }
    }
}
