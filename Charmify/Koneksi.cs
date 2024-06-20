using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Charmify
{
    internal class Koneksi
    {
        public MySqlConnection Getconn()
        {
            String connstring = "server=localhost;uid=root;pwd=Anonymous626;database=charmify";
            MySqlConnection conn = new MySqlConnection(connstring);
            return conn;

            /*string sql = "select * from chramify";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();*/
        }
    }
}
