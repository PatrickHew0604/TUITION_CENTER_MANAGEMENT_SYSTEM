using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Odbc;
using System.ServiceModel.Channels;

namespace LoginInterface
{
    internal class Tutor
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string ContactNum { get; set; }
        public string IcNum { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Tutor() { }

        public Tutor(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            // Let the tutor to contain this all kind of attribute for the use of editing own profile
            SqlDataReader dataReader = con.DataReader($"SELECT staff_id, name, gender, contact_number, ic_number, email, address FROM staff WHERE username = '{username}'");
            while (dataReader.Read())
            {
                this.Name = dataReader["name"].ToString();
                this.Gender = dataReader["gender"].ToString();
                this.ContactNum = dataReader["contact_number"].ToString();
                this.IcNum = dataReader["ic_number"].ToString();
                this.Email = dataReader["email"].ToString();
                this.Address = dataReader["address"].ToString();
            }
            con.Close();
        }
        public void UpdateOwnProfileForm()
        {
            OwnProfileTutor ownProfileTutor = new OwnProfileTutor(this.Username, this.Password, this.Name, this.IcNum, this.Email, this.ContactNum, this.Address, this.Gender);
            ownProfileTutor.Show();

        }public void HomePageForm() 
        {
            HomePageTutor tutor = new HomePageTutor(this.Username, this.Password);
            tutor.Show();
        }

        public void AddClassInfo()
        {
            FormAddInfo addInfo = new FormAddInfo(this.Username, this.Password);
            addInfo.Show();
        }
        public void DeleteClassInfo()
        {
            DeleteClass delClass = new DeleteClass(this.Username, this.Password);
            delClass.Show();
        }

        public void EditClass() 
        {
            EditInfo editClass = new EditInfo(this.Username, this.Password);
            editClass.Show();
        }

        public void EnrolStudentInClass() 
        {
            RegisterStdInClass regStdInClass = new RegisterStdInClass(this.Username, this.Password);
            regStdInClass.Show();
        }
        public void ViewStdList()
        {
            Form_View_Student_List viewList = new Form_View_Student_List();
            viewList.Show();
        }

        public void ViewClassInfo()
        {
            ClassInformation viewClass = new ClassInformation();
            viewClass.Show();
        }
        public void UpdateProfile(params string[] datas)//P
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            string query = $"UPDATE staff SET password = '{datas[1]}', name = '{datas[2]}', ic_number = '{datas[3]}', email = '{datas[4]}', contact_number = '{datas[5]}', address = '{datas[6]}' WHERE username = '{datas[0]}'";
            con.UpdateData(query);
            con.Close();
            Notification noti = new Notification("Profile has been updated");
            noti.Show();
        }
        public void UpdateClassInfo(params string[] datas) 
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            //Haven't update the staffid before login was done
            string query = $"UPDATE class SET class_name = '{datas[1]}', subject_id = '{Convert.ToInt32(datas[2])}', day_Of_Week = '{datas[3]}', starting_time = '{datas[4]}', duration = {Convert.ToInt32(datas[5])} WHERE class_id = {Convert.ToInt32(datas[0])}";
            con.UpdateData(query);
            con.Close();
            Notification noti = new Notification("Class has been updated");
            noti.Show();
        }


                
        //params is a keyword that can takes a variable number of arguments
        public void AddInfoToDatabase(params string[] datas)
        {
            string[] clone = new string[datas.Length];
            for(int i = 0 ; i<datas.Length; i++) 
            {
                clone[i] = datas[i];
            }
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            //Haven't add staffID into it
            string[] capslt = new string[] { "@staff_id","@class_Name", "@subject_id", "@tuition_Time", "@duration", "@day_Of_Week" };
            string query = @"INSERT INTO class ( staff_id, class_Name, subject_id, starting_Time, duration, day_Of_Week)
            VALUES ( @staff_id, @class_Name, @subject_id, @tuition_Time, @duration, @day_Of_Week )";
            con.InsertInToDB(capslt, clone, query);
            con.Close();

        }
        
        //Retrive the subject ID for the upload and edit  data into class
        public string RetriveSubject(string subject, int level)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            string subjectID = (con.RetrieveData($"SELECT subject_id FROM subject WHERE subject_name = '{subject}' AND subject_level = {level}")).ToString();
            con.Close();
            return subjectID;
        }

        public string RetriveStaffID(string username, string password) 
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            string staffID = (con.RetrieveData($"SELECT staff_id FROM staff WHERE username = '{username}' AND password = '{password}'")).ToString();
            con.Close();
            return staffID;
        }

        public List<string> RetrieveSubjectView(string stdID) 
        {
            List<string> temp = new List<string>();
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            SqlDataReader drd = con.DataReader($"SELECT subject_id FROM student_subject WHERE student_id = {stdID}");
            while (drd.Read())
            {
                temp.Add(drd[0].ToString());
            }
            return temp;
        }
        public DataTable SearchClass(int classID)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            DataTable dtable = (DataTable)con.RetriveDataInTable($"SELECT * FROM class WHERE class_id LIKE '%{classID}%'");
            con.Close();
            return dtable;
        }

        public DataTable SearchStudent(int studentID) 
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            DataTable dtable = (DataTable)con.RetriveDataInTable($"SELECT * FROM student_subject WHERE student_id = {studentID}");
            con.Close();
            return dtable;
        }

        public DataTable SearchStudentClass(int studentID)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            DataTable dtable = (DataTable)con.RetriveDataInTable($"SELECT * FROM student_class WHERE student_id = {studentID}");
            con.Close();
            return dtable;
        }

        public DataTable SearchSubject(List<string> subs)
        {
            DataTable dtable = new DataTable();
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            if (subs.Count == 1)
            {
                dtable = (DataTable)con.RetriveDataInTable($"SELECT * FROM subject WHERE subject_id =  {subs[0]}");
            }
            else if (subs.Count ==2 )
            {
                dtable = (DataTable)con.RetriveDataInTable($"SELECT * FROM subject WHERE subject_id =  {subs[0]} OR subject_id = {subs[1]}");
            }
            else
            {
                dtable = (DataTable)con.RetriveDataInTable($"SELECT * FROM subject WHERE subject_id =  {subs[0]} OR subject_id =  {subs[1]} OR subject_id =  {subs[2]}");
            }
            
            con.Close();
            return dtable;
        }

        public Dictionary<string, string> RetrieveClassData(string classID)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            Dictionary<string, string> classInfo = new Dictionary<string, string>();
            SqlDataReader drd = con.DataReader($"SELECT class_id,staff_id,class_name,subject.subject_name,subject.subject_level, starting_time,duration,day_of_week,subject.fee_per_month FROM class INNER JOIN subject ON class.subject_id = subject.subject_id WHERE class_id = {classID} ");
            while (drd.Read())
            {
                classInfo["classID"] = drd[0].ToString();
                classInfo["staffID"] = drd[1].ToString();
                classInfo["className"] = drd[2].ToString();
                classInfo["subjectName"] = drd[3].ToString();
                classInfo["subjectLevel"] = drd[4].ToString();
                classInfo["startingTime"] = drd[5].ToString();
                classInfo["duration"] = drd[6].ToString();
                classInfo["dayOfWeek"] = drd[7].ToString();
                classInfo["feePerMonth"] = drd[8].ToString();
            }
            return classInfo;
        }

        public void DeleteClass(int classID)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            con.DeleteData($"DELETE FROM class WHERE class_id = {classID}");
            con.Close();
        }

        public void AssignStudentToClass(params string[] stdClass)
        {
            string[] clone = stdClass;
            for (int i = 0; i < stdClass.Length; i++)
            {
                clone[i] = stdClass[i];
            }
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            string[] capslt = new string[] { "@student_id", "@class_id" };
            string query = @"INSERT INTO student_class ( student_id, class_id )
            VALUES ( @student_id, @class_id)";
            con.InsertInToDB(capslt, clone, query);
            con.Close();

        }

        public string RetrieveClassSubID(string clsSubID)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            string classSubID = (con.RetrieveData($"SELECT subject_id FROM class" +
                $" WHERE class_id = '{clsSubID}'")).ToString();
            con.Close();
            return classSubID;
        }

    }
}
