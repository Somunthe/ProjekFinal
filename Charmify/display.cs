using Charmify.Resources;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charmify
{
    public partial class display : Form
    {
        private MySqlCommand cmd;
        Koneksi konn = new Koneksi();
        public display()
        {
            InitializeComponent();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            cart frmcart = new cart();
            frmcart.Show();
            this.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = konn.Getconn();
            if (JumlahStrErg.Value > 0)
            {
                conn.Open();
                cmd = new MySqlCommand("insert into keranjang (nama_barang, harga_barang, jumlah_barang, total_harga, pemesan) values ('Strawberry Earring', '10000', '" + JumlahStrErg.Value + "', 10000 * " + JumlahStrErg.Value + ", '" + login.username + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (JumlahSmlNek.Value > 0)
            {
                conn.Open();
                cmd = new MySqlCommand("insert into keranjang (nama_barang, harga_barang, jumlah_barang, total_harga, pemesan) values ('Smile Nekclace', '30000', '" + JumlahSmlNek.Value + "', 30000 * " + JumlahSmlNek.Value + ", '" + login.username + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (JumlahBFlyBrac.Value > 0)
            {
                conn.Open();
                cmd = new MySqlCommand("insert into keranjang (nama_barang, harga_barang, jumlah_barang, total_harga, pemesan) values ('Butterfly Bracelet', '20000', '" + JumlahBFlyBrac.Value + "', 20000 * " + JumlahBFlyBrac.Value + ", '" + login.username + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (JumlahLoveRing.Value > 0)
            {
                conn.Open();
                cmd = new MySqlCommand("insert into keranjang (nama_barang, harga_barang, jumlah_barang, total_harga, pemesan) values ('Love Ring', '5000', '" + JumlahLoveRing.Value + "', 5000 * " + JumlahLoveRing.Value + ", '" + login.username + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (JumlahBFlyEar.Value > 0)
            {
                conn.Open();
                cmd = new MySqlCommand("insert into keranjang (nama_barang, harga_barang, jumlah_barang, total_harga, pemesan) values ('Butterfly Earring', '10000', '" + JumlahBFlyEar.Value + "', 10000 * " + JumlahBFlyEar.Value + ", '" + login.username + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (JumlahChockerNkc.Value > 0)
            {
                conn.Open();
                cmd = new MySqlCommand("insert into keranjang (nama_barang, harga_barang, jumlah_barang, total_harga, pemesan) values ('Chocker Nekclace', '30000', '" + JumlahChockerNkc.Value + "', 30000 * " + JumlahChockerNkc.Value + ", '" + login.username + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (JumlahStarBrac.Value > 0)
            {
                conn.Open();
                cmd = new MySqlCommand("insert into keranjang (nama_barang, harga_barang, jumlah_barang, total_harga, pemesan) values ('Star Bracelet', '20000', '" + JumlahStarBrac.Value + "', 20000 * " + JumlahStarBrac.Value + ", '" + login.username + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            if (JumlahRnbwRing.Value > 0)
            {
                conn.Open();
                cmd = new MySqlCommand("insert into keranjang (nama_barang, harga_barang, jumlah_barang, total_harga, pemesan) values ('Rainbow Ring', '5000', '" + JumlahRnbwRing.Value + "', 5000 * " + JumlahRnbwRing.Value + ", '" + login.username + "')", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Pesanan berhasil dimasukkan ke dalam keranjang");
            JumlahBFlyBrac.Value = 0;
            JumlahBFlyEar.Value = 0;
            JumlahChockerNkc.Value = 0;
            JumlahLoveRing.Value = 0;
            JumlahRnbwRing.Value = 0;
            JumlahSmlNek.Value = 0;
            JumlahStarBrac.Value = 0;
            JumlahStrErg.Value = 0;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            login frmlogin = new login();
            frmlogin.Show();
            this.Close();
        }
    }
}
