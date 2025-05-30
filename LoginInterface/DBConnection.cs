using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;
using System.Xml.Linq;

// Created By Patrick

namespace LoginInterface
{
    internal class DBConnection
    {
        // This might be Changed !
        string ConnectionString =
    ConfigurationManager.ConnectionStrings["DB_Connetion_String"].ToString();
        SqlConnection con;

        public void EstablishConnection()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }
        public void Close()
        {
            con.Close();
            con.Dispose();
        }

        public void UpdateData(string Query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(Query, con);
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.ExecuteNonQuery();
        }

        public void DeleteData(string Query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = new SqlCommand(Query, con);
            adapter.DeleteCommand.ExecuteNonQuery();
        }
        // Multiple Data
        public SqlDataReader DataReader(string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        public object RetriveDataInTable(string Query)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query, ConnectionString);
            DataTable dtable = new DataTable();
            dr.Fill(dtable);
            return dtable;
        }
        // Single Data
        public object RetrieveData(string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, con);
            object temp = cmd.ExecuteScalar();
            return temp;
        }

        public void InsertInToDB(string[] ori, string[] encap, string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, con);
            for (int i = 0; i < ori.Length; i++)
            {
                cmd.Parameters.AddWithValue(ori[i], encap[i]);
            }
            cmd.ExecuteNonQuery();
        }
    }
}
