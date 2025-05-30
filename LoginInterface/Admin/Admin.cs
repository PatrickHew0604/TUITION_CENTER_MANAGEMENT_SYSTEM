using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginInterface
{
    internal class Admin
    {
        public string Password { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string ICPassport { get; set; }
        public string Email { get; set; }
        public string ContactNum { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        private int level;

        public Admin()
        {

        }

        public Admin(string username,string password)
        {
            this.Password = password;
            this.Username = username;
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            SqlDataReader drd = con.DataReader($"SELECT username,password,name,ic_number,email,address,contact_number,gender FROM staff WHERE username = '{this.Username}' AND password = '{this.Password}'");
            while (drd.Read())
            {
                this.Name = drd["name"].ToString();
                this.ICPassport = drd["ic_number"].ToString();
                this.Email = drd["email"].ToString();
                this.ContactNum = drd["contact_number"].ToString();
                this.Address = drd["address"].ToString();
                this.Gender = drd["gender"].ToString();
            }
        }

        //insert tutor's information into staff table
        public void RegisterTutorInToDatabase_staff(params string[] datas)
        {
            string[] clone = new string[datas.Length + 1];
            for (int i = 0; i < datas.Length; i++)
            {
                clone[i] = datas[i];
            }
            clone[datas.Length] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            string[] ori = new string[] { "@username", "@password", "@name", "@gender", "@contact_number", "ic_number", "email", "@address", "@last_online" };
            string query = @"INSERT INTO staff (username,password,role,name,gender,contact_number,ic_number,email,address,last_online) 
            VALUES (@username,@password,'Tutor',@name,@gender,@contact_number,@ic_number,@email,@address,@last_online)";
            con.InsertInToDB(ori, clone, query);
            con.Close();

        }

        //insert tutor's information into staff_subject table
        public void RegisterTutorInToDatabase_staff_subject(params string[] datas)
        {
            string[] clone = new string[datas.Length - 1];
            clone[0] = datas[0];
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            string[] ori = new string[] { "@staff_id", "@subject_id" };
            int tutor_ID = Convert.ToInt32(con.RetrieveData($"SELECT staff_id FROM staff WHERE username = '{datas[0]}'"));
            clone[0] = tutor_ID.ToString();
            int subject_ID = Convert.ToInt32(con.RetrieveData($"SELECT subject_id FROM subject WHERE subject_level = {datas[1]} AND subject_name = '{datas[2]}'"));
            if (subject_ID == 0)
            {
                string[] ori_add = new string[] { "@subject_name", "@subject_level", "@fee_per_month" };
                string[] clone_add = new string[3];
                clone_add[0] = datas[2];
                clone_add[1] = datas[1];
                if (datas[1] == "1")
                {
                    clone_add[2] = "100";
                }
                else if (datas[1] == "2")
                {
                    clone_add[2] = "110";
                }
                else if (datas[1] == "3")
                {
                    clone_add[2] = "120";
                }
                else if (datas[1] == "4")
                {
                    clone_add[2] = "130";
                }
                else if (datas[1] == "5")
                {
                    clone_add[2] = "140";
                }
                string query_add = $@"INSERT INTO subject (subject_name,subject_level,fee_per_month) VALUES (@subject_name,@subject_level,@fee_per_month)";
                con.InsertInToDB(ori_add, clone_add, query_add);
            }
            subject_ID = Convert.ToInt32(con.RetrieveData($"SELECT subject_id FROM subject WHERE subject_level = {datas[1]} AND subject_name = '{datas[2]}'"));
            clone[1] = subject_ID.ToString();
            string query = $@"INSERT INTO staff_subject (staff_id,subject_id) VALUES ('{tutor_ID}', {subject_ID})";
            con.InsertInToDB(ori, clone, query);
            con.Close();
        }

        //insert receptionist's information into staff table
        public void RegisterReceptionistInToDatabase(params string[] datas)
        {
            string[] clone = new string[datas.Length + 1];
            for (int i = 0; i < datas.Length; i++)
            {
                clone[i] = datas[i];
            }
            clone[datas.Length] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            string[] ori = new string[] { "@username", "@password", "@name", "@gender", "@contact_number", "@ic_number", "@email", "@address", "@last_online" };
            string query = @"INSERT INTO staff (username,password,role,name,gender,contact_number,ic_number,email,address,last_online) 
            VALUES (@username,@password,'Receptionist',@name,@gender,@contact_number,@ic_number,@email,@address,@last_online)";
            con.InsertInToDB(ori, clone, query);
            con.Close();

        }

        //delete tutor
        public void RemoveTutor(string tuUsername)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            int tutor_ID = 0;
            tutor_ID = Convert.ToInt32(con.RetrieveData($"SELECT staff_id FROM staff WHERE username = '{tuUsername}' AND role = 'Tutor'"));
            SqlDataReader drd = con.DataReader($"SELECT class_id FROM class WHERE staff_id = '{tutor_ID}'");
            while (drd.Read())
            {
                con.EstablishConnection();
                con.DeleteData($"DELETE FROM student_class WHERE class_id = '{drd[0]}'");
                con.Close();
            }
            con.EstablishConnection();
            con.DeleteData($"DELETE FROM class WHERE staff_id = '{tutor_ID}'");
            con.DeleteData($"DELETE FROM staff_subject WHERE staff_id = '{tutor_ID}'");
            con.DeleteData($"DELETE FROM staff WHERE staff_id = '{tutor_ID}'");
            con.Close();
        }

        //delete receptionist
        public void RemoveReceptioinist(string reUsername)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            int receptionist_ID = 0;
            receptionist_ID = Convert.ToInt32(con.RetrieveData($"SELECT staff_id FROM staff WHERE username = '{reUsername}' AND role = 'Receptionist'"));
            con.DeleteData($"DELETE FROM staff WHERE staff_id = '{receptionist_ID}'");
            con.Close();
        }


        public DataTable SearchTutor(string username)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            //DataTable dtable = (DataTable)con.RetriveDataInTable($"SELECT * FROM staff WHERE username LIKE '%{username}%' AND role = 'Tutor'");
            DataTable dtable = (DataTable)con.RetriveDataInTable($"SELECT * FROM staff WHERE username LIKE '%{username}%'");
            con.Close();
            return dtable;
        }

        public DataTable SearchReceptionist(string username)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            //DataTable dtable = (DataTable)con.RetriveDataInTable($"SELECT * FROM staff WHERE username LIKE '%{username}%' AND role = 'Receptionist'");
            DataTable dtable = (DataTable)con.RetriveDataInTable($"SELECT * FROM staff WHERE username LIKE '%{username}%'");
            con.Close();
            return dtable;
        }

        public int TutorSubjectLevel(string username, string subject)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            int tutor_ID = Convert.ToInt32(con.RetrieveData($"SELECT staff_id FROM staff WHERE username = '{username}'"));
            SqlDataReader drd = con.DataReader($"SELECT subject_id FROM staff_subject WHERE staff_id = {tutor_ID}");
            while (drd.Read())
            {
                con.EstablishConnection();
                if (subject != con.RetrieveData($"SELECT subject_name FROM subject WHERE subject_id = {drd[0]}").ToString())
                {
                    con.Close();
                }
                else
                {
                    level = Convert.ToInt32($"SELECT subject_level FROM subject WHERE subject_id = {drd[0]}");
                    con.Close();
                    break;
                }
            }
            return level;
        }

        public void UpdateProfile_admin(params string[] datas)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            int staff_ID = Convert.ToInt32(con.RetrieveData($"SELECT staff_id FROM staff WHERE username = '{datas[0]}' AND role = 'Admin'"));
            string query = $"UPDATE staff SET password = {datas[1]}, name = '{datas[2]}', ic_number = {datas[3]}, email = '{datas[4]}', contact_number = {datas[5]}, address = '{datas[6]}' WHERE staff_id = {staff_ID} AND role = 'Admin'";
            con.UpdateData(query);
            con.Close();
        }

        public int Income_report(int month, string level, string subject)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            int total_income = 0;
            int num_student = 0;
            int subject_ID = Convert.ToInt32(con.RetrieveData($"SELECT subject_id FROM subject WHERE subject_level = {level} AND subject_name = '{subject}'"));
            int fee_per_month = Convert.ToInt32(con.RetrieveData($"SELECT fee_per_month FROM subject WHERE subject_id = {subject_ID} GROUP BY subject_id, fee_per_month"));
            SqlDataReader drd = con.DataReader($"SELECT MONTH(payment_date), COUNT(payment_id) FROM payment WHERE subject_id = {subject_ID} AND MONTH(payment_date) = {month} GROUP BY MONTH(payment_date)\r\n");
            while (drd.Read())
            {
                num_student = Convert.ToInt32(drd[1]);

            }
            total_income = num_student * fee_per_month;
            con.Close();
            return total_income;

        }

        public void TutorForm()
        {
            Form1 tutor_info = new Form1(this.Username, this.Password);
            tutor_info.Show();
        }

        public void ReceptionistForm()
        {
            Form2 receptionist_info = new Form2(this.Username, this.Password);
            receptionist_info.Show();
        }

        public void IncomeReportForm()
        {
            Form3 income_report = new Form3(this.Username, this.Password);
            income_report.Show();
        }

        public void OwnProfileForm()
        {

            OwnProfile_Admin own_profile = new OwnProfile_Admin(this.Username, this.Password, this.Name, this.ICPassport, this.Email, this.Address, this.ContactNum, this.Gender);
            own_profile.Show();

        }

        public void HomePage()
        {
            HomePage_Admin homePage_Admin = new HomePage_Admin(this.Username, this.Password);
            homePage_Admin.Show();
        }
    }
}
