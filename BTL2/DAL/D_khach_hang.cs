using BTL2.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL2.DAL
{
    public class D_khach_hang
    {
        public static DataTable getData()
        {
            MySqlConnection Conn = dbConnectionData.connect();
            MySqlCommand cmd = new MySqlCommand("getAll_Khachhang", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            Conn.Dispose();
            return dt;
        }

        public static DataTable search(string id, string CMND , string job , string phone ,string Sex , string email ,string dob)
        {
            //Search(id, CMND , job , phone , Sex , email , dob )
            using (MySqlConnection Conn = dbConnectionData.connect())
            {
                MySqlCommand cmd = new MySqlCommand("Search", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", MySqlDbType.VarChar, 20);
                cmd.Parameters.Add("@CMND", MySqlDbType.VarChar, 20);
                cmd.Parameters.Add("@job", MySqlDbType.VarChar, 20);
                cmd.Parameters.Add("@phone", MySqlDbType.VarChar, 20);
                cmd.Parameters.Add("@Sex", MySqlDbType.VarChar, 20);
                cmd.Parameters.Add("@email", MySqlDbType.VarChar, 40);
                cmd.Parameters.Add("@dob", MySqlDbType.VarChar, 40);
                cmd.Parameters["@id"].Value = id;
                cmd.Parameters["@CMND"].Value = CMND;
                cmd.Parameters["@job"].Value = job;
                cmd.Parameters["@phone"].Value = phone;
                cmd.Parameters["@Sex"].Value = Sex;
                cmd.Parameters["@email"].Value = email;
                cmd.Parameters["@dob"].Value = dob;
                //MessageBox.Show(dob);
                Conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                Conn.Close();
                // Conn.Dispose();
                return dt;
            }
        }
    }
}
