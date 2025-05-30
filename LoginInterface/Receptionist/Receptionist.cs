using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data;
using System.Collections;
using ComponentFactory.Krypton.Toolkit;

namespace LoginInterface
{
    internal class Receptionist
    {
        public string Address { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string ICPassport { get; set; }
        public string Email { get; set; }
        public string ContactNum { get; set; }
        public string Gender { get; set; }

        public Receptionist() { }

        public Receptionist(string username, string password)
        {
            this.Password = password;
            this.Username = username;
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            SqlDataReader drd = 
                con.DataReader($"SELECT name,ic_number,email,contact_number,gender,address FROM staff WHERE username = '{username}'");
            while (drd.Read())
            {
                this.Name = drd["name"].ToString();
                this.ICPassport = drd["ic_number"].ToString();
                this.Email = drd["email"].ToString();
                this.ContactNum = drd["contact_number"].ToString();
                this.Gender = drd["gender"].ToString();
                this.Address = drd["address"].ToString();
            }
            con.Close();
        }

        public void StudentRequestForm()
        {
            RequestDBView reqStu = new RequestDBView();
            reqStu.Show();
        }

        public void RegisterStudentForm()
        {
            RegisterStudent regStu = new RegisterStudent(this.Username, this.Password);
            regStu.Show();
        }

        public void DeleteStudentForm()
        {
            DeleteStudent delStu = new DeleteStudent(this.Username, this.Password);
            delStu.Show();
        }

        public void ReceivePaymentForm()
        {
            AcceptPayment acceptPayment = new AcceptPayment(this.Username, this.Password);
            acceptPayment.Show();
        }

        public void UpdateEnrollmentForm()
        {
            UpdateEnrollMent updateEnrollMent = new UpdateEnrollMent(this.Username, this.Password);
            updateEnrollMent.Show();
        }

        public void HomePageForm()
        {
            HomePage recep = new HomePage(this.Username , this.Password ,this.Name);
            recep.Show();
        }

        public void UpdateOwnProfileForm()
        {
            OwnProfile ownProfile = new OwnProfile(this.Username, this.Password, this.Name, this.ICPassport, this.Email, this.ContactNum, this.Address, this.Gender);
            ownProfile.Show();
        }

        public void EnrollSubject(string username, string subject, int level)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            string studentID = (con.RetrieveData($"SELECT student_id FROM student WHERE username = '{username}'")).ToString();
            string subjectID =  (con.RetrieveData($"SELECT subject_id FROM subject WHERE subject_name = '{subject}' AND subject_level = {level}")).ToString();
            string[] ori = { "@student_id", "@subject_id"};
            string[] datas = { studentID, subjectID};
            string query = $"INSERT INTO student_subject (student_id,subject_id) VALUES (@student_id,@subject_id)";
            con.InsertInToDB(ori, datas, query);
            con.Close();
        }
        
        public void RegisterStudent(params string[] datas)
        {
            string[] clone = new string[datas.Length + 2];
            for (int i = 0; i < datas.Length; i++)
            {
                clone[i] = datas[i];
            }
            clone[datas.Length] = DateTime.Now.ToString("yyyy-MM-dd");
            clone[datas.Length + 1] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            string[] ori = new string[] { "@username","@password","@name","@ic_number","@email","@contact_number","@gender","@level","@date_of_enrollment","@last_online" };
            string query =@"INSERT INTO student (username,password,name,ic_number,email,contact_number,gender,level,date_of_enrollment,last_online) 
            VALUES (@username,@password,@name,@ic_number,@email,@contact_number,@gender,@level,@date_of_enrollment,@last_online)";
            con.InsertInToDB(ori, clone, query);
            con.Close();
        }

        public float GetTotal(string studentLevel ,List<string> paySub)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            float total = 0f;
            Dictionary<string, string> availableSubs = AvailableSubIDValuePair(studentLevel);
            if (paySub.Count == 1)
            {
                total += Convert.ToInt32(con.RetrieveData($"SELECT fee_per_month FROM subject WHERE subject_id = {availableSubs[paySub[0]]}"));
                
            }
            else if (paySub.Count == 2)
            {
                total += Convert.ToInt32(con.RetrieveData($"SELECT fee_per_month FROM subject WHERE subject_id = {availableSubs[paySub[0]]}"));
                total += Convert.ToInt32(con.RetrieveData($"SELECT fee_per_month FROM subject WHERE subject_id = {availableSubs[paySub[1]]}"));
            }
            else
            {
                total += Convert.ToInt32(con.RetrieveData($"SELECT fee_per_month FROM subject WHERE subject_id = {availableSubs[paySub[0]]}"));
                total += Convert.ToInt32(con.RetrieveData($"SELECT fee_per_month FROM subject WHERE subject_id = {availableSubs[paySub[1]]}"));
                total += Convert.ToInt32(con.RetrieveData($"SELECT fee_per_month FROM subject WHERE subject_id = {availableSubs[paySub[2]]}"));
            }
            con.Close();
            return total;
        }

        public void UpdatePayment(string stuUsername,List<string> paySub)
        {
            
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            Dictionary<string,string> stuInfo = RetrieveStudentData(stuUsername);
            string studentLevel = stuInfo["studentLevel"];
            Dictionary<string, string> availableSubs = AvailableSubIDValuePair(studentLevel);
            string studentID = stuInfo["studentID"];
            string query = $"INSERT INTO payment (student_id,subject_id,payment_date) VALUES (@student_id, @subject_id, @payment_date)";
            if (paySub.Count == 1)
            {
                con.InsertInToDB(new string[] { "@student_id", "@subject_id", "@payment_date" }, new string[] { studentID, availableSubs[paySub[0]], DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") }, query);
            }
            else if (paySub.Count == 2)
            {
                con.InsertInToDB(new string[] { "@student_id", "@subject_id", "@payment_date" }, new string[] { studentID, availableSubs[paySub[0]], DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") }, query);
                con.InsertInToDB(new string[] { "@student_id", "@subject_id", "@payment_date" }, new string[] { studentID, availableSubs[paySub[1]], DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") }, query);
            }
            else
            {
                con.InsertInToDB(new string[] { "@student_id", "@subject_id", "@payment_date" }, new string[] { studentID, availableSubs[paySub[0]], DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") }, query);
                con.InsertInToDB(new string[] { "@student_id", "@subject_id", "@payment_date" }, new string[] { studentID, availableSubs[paySub[1]], DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") }, query);
                con.InsertInToDB(new string[] { "@student_id", "@subject_id", "@payment_date" }, new string[] { studentID, availableSubs[paySub[2]], DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") }, query);
            }
            con.Close();
        }

        public void RemoveStudent(string stuUsername)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            Dictionary<string, string> stuInfo = RetrieveStudentData(stuUsername);
            string stuID = stuInfo["studentID"];
            con.DeleteData($"DELETE FROM payment WHERE student_id = '{stuID}'");
            con.DeleteData($"DELETE FROM request WHERE student_id = '{stuID}'");
            con.DeleteData($"DELETE FROM student_class WHERE student_id = '{stuID}'");
            con.DeleteData($"DELETE FROM student_subject WHERE student_id = '{stuID}'");
            con.DeleteData($"DELETE FROM student WHERE student_id = '{stuID}'");
            con.Close();
        }

        public void UpdateProfile(params string[] datas)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            string query = 
                $"UPDATE staff SET password = '{datas[1]}', name = '{datas[2]}', ic_number = '{datas[3]}', email = '{datas[4]}', contact_number = '{datas[5]}', address = '{datas[6]}' WHERE username = '{datas[0]}'";
            con.UpdateData(query);
            con.Close();
            Notification noti = new Notification("Profile has been updated");
            noti.Show();
        }

        // Used On Data Grind View
        public DataTable SearchStudent(string username = "")
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            DataTable dtable = new DataTable();
            if (username != String.Empty)
            {
                dtable = (DataTable)con.RetriveDataInTable($"SELECT * FROM student WHERE username LIKE '%{username}%'");
            }
            else
            {
                dtable = (DataTable)con.RetriveDataInTable($"SELECT * FROM student");
            }
            con.Close();
            return dtable;
        }

        public DataTable SearchStudentSubjects(string username = "")
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            DataTable dtable = new DataTable();
            if (username != String.Empty)
            {
                dtable = (DataTable)con.RetriveDataInTable($"SELECT * FROM stu_subs WHERE username LIKE '%{username}%'");
            }
            else
            {
                dtable = (DataTable)con.RetriveDataInTable($"SELECT * FROM stu_subs");
            }
            con.Close();
            return dtable;
        }

        public Dictionary<string,string> RetrieveStudentData(string username)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            Dictionary<string, string> studentInfo = new Dictionary<string, string>();
            SqlDataReader drd = 
                con.DataReader($"SELECT student_id,name,gender,level,ic_number,contact_number,email,date_of_enrollment,last_online FROM student WHERE username = '{username}'");
            while (drd.Read())
            {
                studentInfo["studentID"] = drd[0].ToString();
                studentInfo["studentName"] = drd[1].ToString();
                studentInfo["studentGender"] = drd[2].ToString();
                studentInfo["studentLevel"] = drd[3].ToString();
                studentInfo["studentIC"] = drd[4].ToString();
                studentInfo["studentContact"] = drd[5].ToString();
                studentInfo["studentEmail"] = drd[6].ToString();
                studentInfo["studentDOE"] = drd[7].ToString();
                studentInfo["studentLastOnline"] = drd[8].ToString();
            }
            return studentInfo;
        }

        public List<string> checkStuChosenSub(string stuUsername)
        {
            List<string> chosenSubs = new List<string>(); 
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            SqlDataReader drd = con.DataReader
                ($"SELECT subject_name FROM subject WHERE subject_id IN (SELECT subject_id FROM student_subject WHERE student_id = (SELECT student_id FROM student WHERE username = '{stuUsername}'))");
            while (drd.Read())
            {
                chosenSubs.Add(drd[0].ToString());
            }
            con.Close();
            return chosenSubs;
        }
        // SUBID Pair for certain level
        public Dictionary<string,string> AvailableSubIDValuePair(string stuLevel)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            Dictionary<string, string> subsIDPair = new Dictionary<string, string>();
            SqlDataReader subTable = con.DataReader($"SELECT subject_id,subject_name FROM subject WHERE subject_level = {stuLevel}");
            while (subTable.Read())
            {
                subsIDPair[subTable[1].ToString()] = subTable[0].ToString();
            }
            return subsIDPair;
        }

        public List<string> GetFirstRowFromDGV()
        {
            List<string> datas = new List<string>();
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            SqlDataReader drd = con.DataReader(@"SELECT * FROM request_list");
            while (drd.Read())
            {
                datas.Add(drd[0].ToString()); // Username 
                datas.Add(drd[2].ToString()); // Current Subject
                datas.Add(drd[3].ToString()); // Changed Subject
                datas.Add(drd[4].ToString()); // Subject Level
                break;
            }
            return datas;
        }

        public void ChangeSubjectInRequest(string username,string stuLevel,string currentSub,string newSub)
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            Dictionary<string, string> studentInfo = RetrieveStudentData(username);
            string studentID = studentInfo["studentID"];
            Dictionary<string, string> subsIDPair = AvailableSubIDValuePair(stuLevel);
            string currentSubID = subsIDPair[currentSub];
            string newSubID = subsIDPair[newSub];
            con.UpdateData($"UPDATE student_subject SET subject_id = {newSubID} WHERE student_id = {studentID} AND subject_id = {currentSubID}");
            con.UpdateData($"UPDATE request SET allowance = 1 WHERE student_id = {studentID} AND current_subject_id = {currentSubID} AND changes_subject_id = {newSubID}");
            con.UpdateData($"UPDATE request SET status = 1 WHERE student_id = {studentID} AND current_subject_id = {currentSubID} AND changes_subject_id = {newSubID}");
            con.Close();
        }

        public void DisallowRequest(string username,string currentSub,string newSub,string stuLevel)
        {
            Dictionary<string, string> studentInfo = RetrieveStudentData(username);
            Dictionary<string, string> subsIDPair = AvailableSubIDValuePair(stuLevel);
            string currentSubID = subsIDPair[currentSub];
            string newSubID = subsIDPair[newSub];
            string studentID = studentInfo["studentID"];
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            con.UpdateData
                ($"UPDATE request SET allowance = 0 WHERE student_id = {studentID} AND current_subject_id = {currentSubID} AND changes_subject_id = {newSubID}");
            con.UpdateData
                ($"UPDATE request SET status = 1 WHERE student_id = {studentID} AND current_subject_id = {currentSubID} AND changes_subject_id = {newSubID}");
            con.Close();
        }

        public DataTable SearchRequest(string username = "")
        {
            DBConnection con = new DBConnection();
            con.EstablishConnection();
            DataTable dtable = new DataTable();
            if (username != String.Empty)
            {
                dtable = (DataTable)con.RetriveDataInTable($"SELECT * FROM request_list WHERE username LIKE '%{username}%'");
            }
            else
            {
                dtable = (DataTable)con.RetriveDataInTable($"SELECT * FROM request_list");
            }
            con.Close();
            return dtable;
        }
    }
}
