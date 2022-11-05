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
    public class D_ThongKe
    {
        public static DataTable getData(ThongKe tk)
        {
            // IN ma char(4), IN tu_ngay date, In toi_ngay date
            using (MySqlConnection Conn = dbConnectionData.connect())
            {
                MySqlCommand cmd = new MySqlCommand("ThongKeLuotNguoi", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ma", MySqlDbType.VarChar, 4);
                cmd.Parameters.Add("@tu_ngay", MySqlDbType.Date);
                cmd.Parameters.Add("@toi_ngay", MySqlDbType.Date);
                cmd.Parameters["@ma"].Value = tk.Ma_tuyen1;
                cmd.Parameters["@tu_ngay"].Value = tk.TuNgay1;
                cmd.Parameters["@toi_ngay"].Value = tk.DenNgay1;
                Conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                Conn.Close();
                //MessageBox.Show(tk.Ma_tuyen1);
                return dt;
            }
        }

        public static DataTable getAllTuyen()
        {
            // IN ma char(4), IN tu_ngay date, In toi_ngay date
            using (MySqlConnection Conn = dbConnectionData.connect())
            {
                MySqlCommand cmd = new MySqlCommand("getAllTuyen", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                Conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                Conn.Close();
                //MessageBox.Show(tk.Ma_tuyen1);
                return dt;
            }
        }
    }
}
