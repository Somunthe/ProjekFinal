using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Charmify.Resources;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace Charmify
{
    public partial class login : Form
    {
        public static string username = "";
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        MySqlDataReader dr;
        Koneksi konn = new Koneksi();

        void kondisiawal()
        {
            tbuser.Text = "";
            tbpass.Text = "";
        }

        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader = null;
            MySqlConnection conn = konn.Getconn();
            {
                conn.Open();
                cmd = new MySqlCommand("select * from user where username ='" + tbuser.Text + "' and password ='" + tbpass.Text + "'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Berhasil login");

                    username = tbuser.Text;

                    display frmdisplay = new display();
                    frmdisplay.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gagal login, ulang kembali");
                }
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            signup frmsignup = new signup();
            frmsignup.Show();
            this.Hide();
        }

        private void login_Load(object sender, EventArgs e)
        {
            kondisiawal();
        }
    }
}
