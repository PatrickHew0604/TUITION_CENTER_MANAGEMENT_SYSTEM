using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Configuration;
using System.Data;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using LoginInterface;

namespace LoginInterface
{
    internal class Student
    {        
        public string StudentID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Names { get; set; }
        public string Level { get; set; }
        public string ICPassport { get; set; }
        public string ContactNum { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string LastOnline { get; set; }
        public string[] Subject { get; set; }
        public string TutorID { get; set; }
        public Student() { }

        public Student(string username, string password)
        {
            this.Password = password;
            this.Username = username;
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            SqlDataReader drd = con.DataReader($"SELECT student_id,name,level FROM student WHERE username = '{username}'");
            while (drd.Read())
            {
                this.StudentID = drd["student_id"].ToString();
                this.Names = drd["name"].ToString();
                this.Level = drd["level"].ToString();
            }
            con.Close();
        }
        public Student(string student_id)
        {
            this.StudentID = student_id;
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            SqlDataReader drd = con.DataReader($"SELECT username, password,name,level,ic_number,email,contact_number,gender FROM student WHERE student_id = {student_id}");
            while (drd.Read())
            {
                this.Username = drd["username"].ToString();
                this.Password = drd["password"].ToString();
                this.Names = drd["name"].ToString();
                this.Level = drd["level"].ToString();
                this.ICPassport = drd["ic_number"].ToString();
                this.Email = drd["email"].ToString();
                this.ContactNum = drd["contact_number"].ToString();
                this.Gender = drd["gender"].ToString();
            }
            con.Close();
        }

        public void Homepage()
        {
            studentHomepage stuHome = new studentHomepage(this.Username, this.Password, this.Names, this.Level, this.StudentID, this.Gender);
            stuHome.Show();
        }
        public void Profile()
        {
            studentProfile stuProfile = new studentProfile(this.StudentID,this.Username, this.Password, this.Names, this.Level, this.ICPassport, this.ContactNum, this.Gender, this.Email);
            stuProfile.Show();
        }
        public void Timetable()
        {
            studentTimetable stuTimetable = new studentTimetable(this.StudentID, this.Username, this.Password);
            stuTimetable.Show();
        }
        public void Request()
        {
            studentRequest stuRequest = new studentRequest(this.StudentID, this.Username, this.Password);
            stuRequest.Show();
        }
        public void Setting()
        {
            studentSetting stuSetting = new studentSetting(this.StudentID);
            stuSetting.Show();
        }
        public void ShowTutor(string tutor_id)
        {
            studentShowTutor stuShowTutor = new studentShowTutor(this.StudentID, tutor_id);
            stuShowTutor.Show();
        }
        public void ShowClassNamelist(string staff_id, string class_name)
        {
            studentShowClassNamelist stuShowClassNamelist = new studentShowClassNamelist(this.StudentID, staff_id, class_name);
            stuShowClassNamelist.Show();
        }
        public void Calculator()
        {
            Calculator calculator = new Calculator();
            calculator.Show();
        }
        public void Logout()
        { LoginForm login = new LoginForm(); login.Show(); }
        public string[] Subjects(string student_id)
        {
            this.StudentID = student_id;
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            DataTable dtable = (DataTable)con.RetriveDataInTable($"SELECT DISTINCT subject.subject_name FROM student_subject INNER JOIN subject ON student_subject.subject_id = subject.subject_id WHERE student_subject.student_id = {student_id}");
            //DataTable dtable = (DataTable)con.RetriveDataInTable
            //    ($"SELECT DISTINCT subject.subject_name FROM student_class " +
            //    $"INNER JOIN class ON student_class.class_id = class.class_id " +
            //    $"INNER JOIN subject ON class.subject_id = subject.subject_id " +
            //    $"WHERE student_class.student_id = {student_id}");
            con.Close();
            return dtable.AsEnumerable().Select(r => r.Field<string>("subject_name")).ToArray();            
        }
        public string[] NonTakenSubjects(string student_id)
        {
            this.StudentID = student_id;
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            DataTable dtable = (DataTable)con.RetriveDataInTable
                ($"SELECT subject_name AS subject FROM subject " +
                $"WHERE subject_level = " +
                $"(SELECT level from student WHERE student_id = '{student_id}') " +
                $"AND subject_name NOT IN " +
                $"(SELECT subject.subject_name FROM student_subject " +
                $"INNER JOIN subject ON subject.subject_id = student_subject.subject_id " +
                $"WHERE student_subject.student_id = '{student_id}')");
            con.Close();
            return dtable.AsEnumerable().Select(r => r.Field<string>("subject")).ToArray();
        }
        public string GetSubjectID(string student_id, string subject_name)
        {
            this.StudentID = student_id;
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            string query = $"SELECT subject_id FROM subject WHERE (subject_level = (SELECT level FROM student WHERE student_id = '{this.StudentID}') AND subject_name = '{subject_name}')";
            string subject_id = con.RetrieveData(query).ToString();
            return subject_id;
        }
        public void RemoveRequest(string[] data)
        {
            string query =
                $"DELETE FROM request WHERE (student_id = {data[0]} AND current_subject_id = {data[1]} AND changes_subject_id = {data[2]})";
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            con.DeleteData(query);
            con.Close();
        }
        public void SendRequest(string student_id, string current_subject_id, string changed_subject_id)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            string query = 
                $"INSERT INTO request (student_id, current_subject_id, changes_subject_id, status)" +
                $"VALUES ( '{student_id}', '{current_subject_id}', '{changed_subject_id}', 0)";
            con.UpdateData(query);
            con.Close();
        }
        public void UpdateProfile(params string[] datas)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            string query = $"UPDATE student SET username = '{datas[1]}', password = '{datas[2]}', email = '{datas[3]}', contact_number = '{datas[4]}' WHERE student_id = '{datas[0]}'";
            con.UpdateData(query);
            con.Close();
        }        
        public string[] Tutor(string tutor_id)
        {
            this.TutorID = tutor_id;
            string[] tutor_detail = new string[5];
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            SqlDataReader drd = con.DataReader($"SELECT name,gender,email,contact_number,last_online FROM staff WHERE staff_id = {tutor_id}");
            while (drd.Read())
            {
                tutor_detail[0] = drd["name"].ToString();
                tutor_detail[1] = drd["gender"].ToString();
                tutor_detail[2] = drd["email"].ToString();
                tutor_detail[3] = drd["contact_number"].ToString();
                tutor_detail[4] = drd["last_online"].ToString();
            }
            con.Close();
            return tutor_detail;
        }
        
    }
}
