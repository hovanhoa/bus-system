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
    public class D_TuyenTauDien
    {
        public static DataTable getData()
        {
            using (MySqlConnection Conn = dbConnectionData.connect())
            {
                MySqlCommand cmd = new MySqlCommand("getAll_TuyenTauDien", Conn);
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

        public static void insert(TuyenTauDien t)
        {
            using (MySqlConnection Conn = dbConnectionData.connect())
            {
                //insert_TuyenTauDien(Ma_tuyen_tau_xe char(4),Ma_tuyen char,ten_tuyen varchar(15),don_gia int,STT int,Ma_ga_tram char(7),STT_ int,Gio_ghe time,Gio_di time)
                MySqlCommand cmd = new MySqlCommand("insert_TuyenTauDien", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add("@Ma_tuyen_tau_xe", MySqlDbType.VarChar,4 );
                cmd.Parameters.Add("@Ma_tuyen", MySqlDbType.VarChar, 1);
                cmd.Parameters.Add("@ten_tuyen", MySqlDbType.VarChar, 15);
                cmd.Parameters.Add("@don_gia", MySqlDbType.Int32);
                cmd.Parameters.Add("@STT", MySqlDbType.Int32);
                
                cmd.Parameters["@Ma_tuyen_tau_xe"].Value = t.Ma_tuyen_tau_xe1;
                cmd.Parameters["@Ma_tuyen"].Value = t.Ma_tuyen1;
                cmd.Parameters["@ten_tuyen"].Value = t.Ten_tuyen;
                cmd.Parameters["@don_gia"].Value = t.Don_gia;
                cmd.Parameters["@STT"].Value = t.STT1;
                
                
               // MessageBox.Show(t.Ma_tuyen_tau_xe1 + " " + t.Ma_tuyen1 + " " + t.Ten_tuyen + " " + t.Don_gia + " " + t.STT1 + " " + t.Ma_ga_tram1 + " " + t.STT_1 + " " + t.Gio_ghe1 + " " + t.Gio_di1);
                Conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
            }
        }
    }
}
