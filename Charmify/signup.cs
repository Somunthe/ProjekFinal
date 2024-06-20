using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charmify
{
    public partial class signup : Form
    {
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        MySqlDataReader dr;
        Koneksi konn = new Koneksi();
        public signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader = null;
            MySqlConnection conn = konn.Getconn();
            {
                conn.Open();
                cmd = new MySqlCommand("select * from user where username ='" + tbuser.Text + "'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Username sudah terdaftar");
                    tbpass2.Text = "";
                    tbuser.Text = "";
                    tbpass.Text = "";
                }
                else
                {
                    if (tbpass.Text == tbpass2.Text)
                    {
                        /*debugmanual*/
                        /*MessageBox.Show(tbuser.Text);
                        MessageBox.Show(tbpass.Text);*/
                        conn.Close();
                        conn.Open();
                        cmd = new MySqlCommand("insert into user (username, password) values('" + tbuser.Text + "','" + tbpass.Text + "')", conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Berhasil terdaftar");
                        conn.Close();
                        login frmlogin = new login();
                        frmlogin.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password tidak sama");
                    }
                }
                
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login frmlogin = new login();
            frmlogin.Show();
            this.Close();
        }
    }
}
