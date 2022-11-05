using BTL2.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL2.DAL
{
    public class D_TuyenBus
    {
        public static DataTable getData()
        {
            using (MySqlConnection Conn = dbConnectionData.connect())
            {
                MySqlCommand cmd = new MySqlCommand("getAll_TuyenBus", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
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

        public static void insert(TuyenBus t)
        {
            using (MySqlConnection Conn = dbConnectionData.connect())
            {

                MySqlCommand cmd = new MySqlCommand("insert_TuyenBus", Conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Ma_tuyen_tau_xe", MySqlDbType.VarChar, 4);
                cmd.Parameters.Add("@No", MySqlDbType.Int32);
                cmd.Parameters.Add("@STT", MySqlDbType.Int32);

                cmd.Parameters["@Ma_tuyen_tau_xe"].Value = t.Ma_tuyen_tau_xe1;
                cmd.Parameters["@No"].Value = t.No1;
                cmd.Parameters["@STT"].Value = t.STT1;

                Conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
            }
        }
    }
}
