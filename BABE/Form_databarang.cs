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
    public partial class Form_databarang : Form
    {
        public Form_databarang()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-5B0DFV64;Initial Catalog=tkbabe;User ID=sa;Password=Duaribu123");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Form_menu().Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            new Form_inputbarang().Show();
            this.Hide();
        }

        private void Form_databarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tkbabeDataSet1.Barang' table. You can move, or remove it, as needed.
            this.barangTableAdapter.Fill(this.tkbabeDataSet1.Barang);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5B0DFV64;Initial Catalog=tkbabe;User ID=sa;Password=Duaribu123");
            SqlCommand cmd = new SqlCommand(" select * from Barang where Id_barang=@Id_barang", con);
            cmd.Parameters.AddWithValue("@Id_barang", int.Parse(textBox1.Text));


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                SqlCommand cmd = new SqlCommand("Delete Barang where Id_barang=@Id_barang", con);

                con.Open();

                cmd.Parameters.AddWithValue("@Id_barang", int.Parse(textBox2.Text));
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show(" berhasil menghapus ");
                Refreshtable();
            }
            void Refreshtable()
            {
                SqlCommand com = new SqlCommand("Select * From Barang", con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
