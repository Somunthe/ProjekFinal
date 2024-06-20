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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Charmify.Resources
{
    public partial class checkout : Form
    {
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        DataSet ds;
        MySqlDataReader dr;
        Koneksi konn = new Koneksi();
        int bypengiriman = 10000;
        DateTime thedate = DateTime.Now;
        string bri = "536001017405";
        string dana = "082112341234";
        string namabri = "Sonya";
        string namadana = "Inayah";

        void jasapengiriman()
        {
            cbpengiriman.Items.Add("JNE");
            cbpengiriman.Items.Add("JNT");
        }

        void kondisiawal()
        {
            tbnama.Text = "";
            tbalamat.Text = "";
            tbhp.Text = "";
            cbpengiriman.Text = "";
            tbbypengiriman.Text = "";
            cbpembayaran.Text = "";
            tbnopembayaran.Text = "";
            tbtotal.Text = "";
        }

        void metodepembayaran()
        {
            cbpembayaran.Items.Add("BRI");
            cbpembayaran.Items.Add("DANA");
        }

        void datapesanan()
        {
            MySqlConnection conn = konn.Getconn();
            conn.Open();
            cmd = new MySqlCommand("Select * from pesanan where pemesan = '" + login.username + "'", conn);
            ds = new DataSet();
            da = new MySqlDataAdapter(cmd);
            da.Fill(ds, "pesanan");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "pesanan";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
            conn.Close();
        }

        public checkout()
        {
            InitializeComponent();
        }

        private void checkout_Load(object sender, EventArgs e)
        {
            kondisiawal();
            jasapengiriman();
            metodepembayaran();
            datapesanan();

            MySqlDataReader reader;
            MySqlConnection conn = konn.Getconn();
            {
                conn.Open();
                cmd = new MySqlCommand("select * from keranjang where pemesan = '" + login.username + "'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    conn.Close();
                    conn.Open();
                    cmd = new MySqlCommand("select sum(total_harga) from keranjang where pemesan = '" + login.username + "'", conn);
                    object total = cmd.ExecuteScalar();
                    int total_akhir = Convert.ToInt32(total) + bypengiriman;
                    tbtotal.Text = Convert.ToString(total_akhir);
                    conn.Close() ;
                }
                else
                {
                    tbtotal.Text = "";
                }
            }
            tbbypengiriman.Text = Convert.ToString(bypengiriman);
            tbbypengiriman.ReadOnly = true;
            tbnopembayaran.ReadOnly = true;
            tbtotal.ReadOnly = true;
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terima kasih sudah berbelanja di Charmify!");
            display frmdisplay = new display();
            frmdisplay.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbtotal.Text == "")
            {
                /*MessageBox.Show(login.username);*/
                MessageBox.Show("Silahkan pesan ulang");
            }
            else
            {
                login frmlogin = new login();
                string user = frmlogin.tbuser.Text;
                MySqlConnection conn = konn.Getconn();
                conn.Open();
                cmd = new MySqlCommand("insert into pesanan (nama, alamat, no_hp, jenis_pengiriman, jenis_pembayaran, no_pembayaran, total_biaya, pemesan) values ('" + tbnama.Text + "', '" + tbalamat.Text + "', '" + tbhp.Text + "', '" + cbpengiriman.Text + "', '" + cbpembayaran.Text + "', '" + tbnopembayaran.Text + "', '" + tbtotal.Text + "', '" + login.username + "' )", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Open();
                cmd = new MySqlCommand("DELETE from keranjang where pemesan = '" + login.username + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Pesanan diproses");
                kondisiawal();
                datapesanan();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cart frmcart = new cart();
            frmcart.Show();
            this.Hide();
        }

        private void cbpembayaran_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbpembayaran.Text == "BRI")
            {
                tbnopembayaran.Text = bri;
                lbnama.Text = namabri;
            }
            else
            {
                tbnopembayaran.Text = dana;
                lbnama.Text = namadana;
            }
        }
    }
}
