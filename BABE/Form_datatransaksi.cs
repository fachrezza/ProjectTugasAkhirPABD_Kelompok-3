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
    public partial class Form_datatransaksi : Form
    {
        public Form_datatransaksi()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-5B0DFV64;Initial Catalog=tkbabe;User ID=sa;Password=Duaribu123");
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Form_menu().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form_inputtransaksi().Show();
            this.Hide();
        }

        private void Form_datatransaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tkbabeDataSet3.Transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.tkbabeDataSet3.Transaksi);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5B0DFV64;Initial Catalog=tkbabe;User ID=sa;Password=Duaribu123");
            SqlCommand cmd = new SqlCommand(" select * from Transaksi where Id_transaksi=@Id_transaksi", con);
            cmd.Parameters.AddWithValue("@Id_transaksi", int.Parse(textBox1.Text));


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                
                SqlCommand cmd = new SqlCommand(" Delete Transaksi where Id_transaksi=@Id_transaksi", con);

                con.Open();

                cmd.Parameters.AddWithValue("@Id_transaksi", int.Parse(textBox2.Text));
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show(" berhasil menghapus");
                Refreshtable();
            }
            void Refreshtable()
            {
                SqlCommand com = new SqlCommand("Select * From Transaksi", con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form_Printreport().Show();
            this.Hide();
        }
    }
}
