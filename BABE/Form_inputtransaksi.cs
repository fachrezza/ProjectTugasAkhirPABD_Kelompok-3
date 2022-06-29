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
    public partial class Form_inputtransaksi : Form
    {
        public Form_inputtransaksi()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Form_datatransaksi().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5B0DFV64;Initial Catalog=tkbabe;User ID=sa;Password=Duaribu123");
            SqlCommand cmd = new SqlCommand(" insert into Transaksi values (@Tanggal_transaksi,@Total_transaksi,@Metode_pembayaran,@Id_pembeli)", con);

            con.Open();

            cmd.Parameters.AddWithValue("@Tanggal_transaksi", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Total_transaksi", textBox5.Text);
            cmd.Parameters.AddWithValue("@Metode_pembayaran", textBox3.Text);
            cmd.Parameters.AddWithValue("@Id_pembeli", int.Parse(textBox1.Text));

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show(" berhasil menambahkan");

            new Form_datatransaksi().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5B0DFV64;Initial Catalog=tkbabe;User ID=sa;Password=Duaribu123");
            SqlCommand cmd = new SqlCommand(" update Transaksi set Tanggal_transaksi=@Tanggal_transaksi,Total_transaksi=@Total_transaksi,Metode_pembayaran=@Metode_pembayaran, Id_pembeli=@Id_pembeli where Id_transaksi = @Id_transaksi", con);

            con.Open();

            cmd.Parameters.AddWithValue("@Tanggal_transaksi", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Total_transaksi", textBox5.Text);
            cmd.Parameters.AddWithValue("@Metode_pembayaran", textBox3.Text);
            cmd.Parameters.AddWithValue("@Id_pembeli", int.Parse(textBox1.Text));

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show(" berhasil memperbarui");

            new Form_datatransaksi().Show();
            this.Hide();
        }
    }
}
