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

namespace Charmify.Resources
{
    public partial class cart : Form
    {
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        DataSet ds;
        MySqlDataReader dr;
        Koneksi konn = new Koneksi();
        object kodekeranjang = "";
        public cart()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkout frmcheckout = new checkout();
            frmcheckout.Show();
            this.Close();
        }

        void datacart()
        {
            MySqlConnection conn = konn.Getconn();
            conn.Open();
            cmd = new MySqlCommand("Select * from keranjang where pemesan = '" + login.username + "'", conn);
            ds = new DataSet();
            da = new MySqlDataAdapter(cmd);
            da.Fill(ds, "keranjang");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "keranjang";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
            conn.Close();
        }

        private void cart_Load(object sender, EventArgs e)
        {
            datacart();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                kodekeranjang = row.Cells["idkeranjang"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = konn.Getconn();
            conn.Open();
            cmd = new MySqlCommand("DELETE from keranjang where idkeranjang ='" + kodekeranjang + "'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Pesanan berhasil dihapus");
            datacart();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = konn.Getconn();
            conn.Open();
            cmd = new MySqlCommand("DELETE from keranjang where pemesan = '" + login.username + "'", conn);
            cmd.ExecuteNonQuery();
            display frmdisplay = new display();
            frmdisplay.Show();
            this.Hide();
            MessageBox.Show("Keranjang dihapus");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display frmdisplay = new display();
            frmdisplay.Show();
            this.Hide();
        }
    }
}
