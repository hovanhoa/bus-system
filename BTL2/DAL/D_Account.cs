using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL2.DAL
{
    public class D_Account
    {
        public static string username = "";
        public static string password = "";
        public static bool checkLogin(string user, string pass)
        {
            string host = "localhost";
            string database = "Assignment2";
            // MySqlConnection conn = new MySqlConnection("server=localhost;Database=app;User ID=root;Password=06052001;SslMode=none");
            string connString = "Server=" + host + ";Database=" + database + ";User Id=" + user + ";password=" + pass + ";SslMode=none";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                conn.Close();
                username = user;
                password = pass;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
