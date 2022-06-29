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
    public partial class Form_inputbeli : Form
    {
        public Form_inputbeli()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Form_databeli().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5B0DFV64;Initial Catalog=tkbabe;User ID=sa;Password=Duaribu123");
            SqlCommand cmd = new SqlCommand(" update Beli set Id_pembeli=@Id_barang,Qty=@Qty,Harga=@Harga where Id_beli=@Id_beli", con);

            con.Open();

            cmd.Parameters.AddWithValue("@Id_pembeli", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@Id_barang", textBox5.Text);
            cmd.Parameters.AddWithValue("@Qty", textBox3.Text);
            cmd.Parameters.AddWithValue("@Harga", textBox2.Text);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show(" berhasil memperbarui");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5B0DFV64;Initial Catalog=tkbabe;User ID=sa;Password=Duaribu123");
            SqlCommand cmd = new SqlCommand(" insert into Beli values (@Id_pembeli,@Id_barang,@Qty,@Harga)", con);

            con.Open();

            cmd.Parameters.AddWithValue("@Id_pembeli", int.Parse(textBox4.Text));
            cmd.Parameters.AddWithValue("@Id_barang", int.Parse(textBox5.Text));
            cmd.Parameters.AddWithValue("@Qty", textBox3.Text);
            cmd.Parameters.AddWithValue("@Harga", textBox2.Text);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show(" berhasil menambahkan");
        }
    }
}
