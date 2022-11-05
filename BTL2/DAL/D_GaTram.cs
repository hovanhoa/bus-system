using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL2.DAL
{
    public class D_GaTram
    {
        public static DataTable getData_GA()
        {
            using (MySqlConnection Conn = dbConnectionData.connect())
            {
                MySqlCommand cmd = new MySqlCommand("getGa", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                Conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                Conn.Close();
                return dt;
            }
        }
        public static DataTable getData_TRAM()
        {
            using (MySqlConnection Conn = dbConnectionData.connect())
            {
                MySqlCommand cmd = new MySqlCommand("getTram", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                Conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                Conn.Close();
                return dt;
            }
        }
    }
}
