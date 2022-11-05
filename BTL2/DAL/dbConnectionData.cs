using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL2.DAL
{
    public class dbConnectionData
    {
        public static MySqlConnection connect()
        {
            string host = "localhost";
            string database = "Assignment2";
            // MySqlConnection conn = new MySqlConnection("server=localhost;Database=app;User ID=root;Password=06052001;SslMode=none");
            string connString = "Server=" + host + ";Database=" + database + ";User Id=" + D_Account.username + ";password=" + D_Account.password + ";SslMode=none";
            //MySqlConnection conn = new MySqlConnection("server=localhost;user id=sManager;Password=1234;database=assignment2;SslMode=none");
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
    }
}
