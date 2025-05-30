using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace LoginInterface
{
    internal class Validation
    {
        public string[] Subjects { get; set; }
        public Validation()
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            SqlDataReader drd = con.DataReader($"SELECT subject_name FROM subject GROUP BY subject_name");
            List<string> temp = new List<string>();
            while (drd.Read())
            {
                temp.Add(drd[0].ToString());
            }
            this.Subjects = temp.ToArray();
            con.Close();
        }

        public bool isTutorExist(string username)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            string query = $"SELECT * FROM staff WHERE username = '{username}' AND role = 'Tutor'";
            DataTable dtable = (DataTable)(con.RetriveDataInTable(query));
            if (dtable.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool isReceptionistExist(string username)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            string query = $"SELECT * FROM staff WHERE username = '{username}' AND role = 'Receptionist'";
            DataTable dtable = (DataTable)(con.RetriveDataInTable(query));
            if (dtable.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<string> GetSubjects(int level)
        {
            DBConnection con = new DBConnection();
            List<string> Subjects = new List<string>();
            con.EstablishConnection();
            SqlDataReader rd = con.DataReader($"SELECT subject_name FROM subject WHERE subject_level = {level}");
            while (rd.Read())
            {
                Subjects.Add(rd["subject_name"].ToString());
            }
            con.Close();
            return Subjects;
        }
        
        public bool isStudentExist(string username)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            string query = $"SELECT * FROM student WHERE username = '{username}'";
            DataTable dtable = (DataTable)(con.RetriveDataInTable(query));
            if (dtable.Rows.Count==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsEmailValid(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            return match.Success;
        }

        public bool IsPhoneNumValid(string phoneNum)
        {
            ulong t;
            return ulong.TryParse(phoneNum.Replace(" ", "").Substring(1), out t);

        }
        public bool[] ValidateStudentData(string username,string email,string phoneNum)
        {
            DBConnection con = new DBConnection();
            bool isEmailValid;
            bool isUsernameValid;
            bool isPhoneNumValid;
            con.EstablishConnection();
            List<string> usernames = new List<string>();
            SqlDataReader dr =  con.DataReader(@"SELECT username FROM role_identifier");
            while (dr.Read())
                usernames.Add(dr.GetValue(0).ToString());
            con.Close();
            isEmailValid = this.IsEmailValid(email);
            isUsernameValid = usernames.Contains(username) ? false : true;
            isPhoneNumValid = this.IsPhoneNumValid(phoneNum);
            return new bool[] { isUsernameValid, isEmailValid, isPhoneNumValid };
        }

        public bool isClassExist(string classID)//J
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            int classid = Convert.ToInt32(classID);
            string query = $"SELECT * FROM class WHERE class_id = {classid}";
            DataTable dtable = (DataTable)(con.RetriveDataInTable(query));
            if (dtable.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool isTimeValid(string inputTime)//J
        {
            Regex checktime =
             new Regex(@"^(([0-1]?[0-9])|([2][0-3]))(:([0-5][0-9])){1,2}$");
            Match match = checktime.Match(inputTime);
            return match.Success;
        }

        bool isNumberValid(string dur)//J
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            Match match = regex.Match(dur);
            return match.Success;
        }

        public bool[] ValidateClassData(string tuitionTime, string duration)//J
        {
            DBConnection con = new DBConnection();
            bool isTimeValid;
            bool isNumberValid;
            con.EstablishConnection();
            List<string> classIDs = new List<string>();
            SqlDataReader dr = con.DataReader(@"SELECT class_id FROM class");
            while (dr.Read())
                classIDs.Add(dr.GetValue(0).ToString());
            con.Close();
            isTimeValid = this.isTimeValid(tuitionTime);
            isNumberValid = this.isNumberValid(duration);
            return new bool[] { isTimeValid, isNumberValid };
        }

        public bool isStdIdEnterValid(string stdId)
        {
            Regex regex = new Regex(@"^[1-9]\d{4}$");
            Match match = regex.Match(stdId);
            return match.Success;
        }

        public bool isStudentInClass(string stdID, string clsID)//J
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            string query = $"SELECT * FROM student_class WHERE student_id = {stdID} AND class_id = {clsID}";
            DataTable dtable = (DataTable)(con.RetriveDataInTable(query));
            if (dtable.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
