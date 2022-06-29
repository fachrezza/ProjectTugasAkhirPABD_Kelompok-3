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
    public partial class Form_inputpembeli : Form
    {
        public Form_inputpembeli()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Form_datapembeli().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5B0DFV64;Initial Catalog=tkbabe;User ID=sa;Password=Duaribu123");
            SqlCommand cmd = new SqlCommand(" insert into Pembeli values (@Id_pembeli,@Nama_pembeli,@Alamat_pembeli,@No_telp)", con);

            con.Open();

            cmd.Parameters.AddWithValue("@Id_pembeli", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Nama_pembeli", textBox4.Text);
            cmd.Parameters.AddWithValue("@No_telp", textBox3.Text);
            cmd.Parameters.AddWithValue("@Alamat_pembeli", textBox2.Text);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show(" berhasil menambahkan");

            new Form_datapembeli().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5B0DFV64;Initial Catalog=tkbabe;User ID=sa;Password=Duaribu123");
            SqlCommand cmd = new SqlCommand(" update Pembeli set Nama_pembeli=@Nama_pembeli,No_telp=@No_telp,Alamat_pembeli=@Alamat_pembeli where Id_pembeli=@Id_pembeli", con);

            con.Open();

            cmd.Parameters.AddWithValue("@Id_pembeli", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Nama_pembeli", textBox4.Text);
            cmd.Parameters.AddWithValue("@No_telp", textBox3.Text);
            cmd.Parameters.AddWithValue("@Alamat_pembeli", textBox2.Text);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show(" berhasil memperbarui");

            new Form_datapembeli().Show();
            this.Hide();
        }
    }
}
