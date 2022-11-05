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
    public class D_Ghe
    {
        public static DataTable getData(string Ma_tuyen)
        {
            using (MySqlConnection Conn = dbConnectionData.connect())
            {
                MySqlCommand cmd = new MySqlCommand("get_LoTrinh", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Ma_tuyen", MySqlDbType.VarChar, 4);
                cmd.Parameters["@Ma_tuyen"].Value = Ma_tuyen;
                Conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                Conn.Close();
                return dt;
            }
        }

        public static void insert(string Ma_tuyen, int STT, Ghe G)
        {
            using (MySqlConnection Conn = dbConnectionData.connect())
            {
                MySqlCommand cmd = new MySqlCommand("insert_ghe", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Ma_tuyen", MySqlDbType.VarChar, 4);
                cmd.Parameters.Add("@STT", MySqlDbType.Int32);
                cmd.Parameters.Add("@Ma_ga_tram", MySqlDbType.VarChar, 7);
                cmd.Parameters.Add("@STT_", MySqlDbType.Int32);
                cmd.Parameters.Add("@Gio_ghe", MySqlDbType.Time);
                cmd.Parameters.Add("@Gio_di", MySqlDbType.Time);

                cmd.Parameters["@Ma_tuyen"].Value = Ma_tuyen;
                cmd.Parameters["@STT"].Value = STT;
                cmd.Parameters["@Ma_ga_tram"].Value = G.Ma_ga_tram1;
                cmd.Parameters["@STT_"].Value = G.STT_1;
                cmd.Parameters["@Gio_ghe"].Value = TimeSpan.Parse(G.Gio_ghe1);
                cmd.Parameters["@Gio_di"].Value = TimeSpan.Parse(G.Gio_di1);
                Conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
            }
        }
    }
}
