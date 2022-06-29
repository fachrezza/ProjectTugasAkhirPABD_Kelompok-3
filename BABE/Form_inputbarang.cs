using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BABE
{
    public partial class Form_inputbarang : Form
    {
        public Form_inputbarang()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Form_databarang().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5B0DFV64;Initial Catalog=tkbabe;User ID=sa;Password=Duaribu123");
            SqlCommand cmd = new SqlCommand(" insert into Barang values (@Id_barang,@Nama_barang,@Jumlah_barang,@Harga_barang)", con);

            con.Open();

            cmd.Parameters.AddWithValue("@Id_barang", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Nama_barang", textBox4.Text);
            cmd.Parameters.AddWithValue("@Jumlah_barang", textBox5.Text);
            cmd.Parameters.AddWithValue("@Harga_barang", textBox3.Text);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show(" berhasil menambahkan");

            new Form_databarang().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5B0DFV64;Initial Catalog=tkbabe;User ID=sa;Password=Duaribu123");
            SqlCommand cmd = new SqlCommand(" update Barang set Nama_Barang = @Nama_barang,Jumlah_barang=@Jumlah_barang,Harga_barang=@Harga_barang Where Id_Barang = @Id_barang", con);

            con.Open();

            cmd.Parameters.AddWithValue("@Id_barang", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Nama_barang", textBox4.Text);
            cmd.Parameters.AddWithValue("@Jumlah_barang", textBox5.Text);
            cmd.Parameters.AddWithValue("@Harga_barang", textBox3.Text);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show(" berhasil memperbarui");

            new Form_databarang().Show();
            this.Hide();
        }
    }
}
