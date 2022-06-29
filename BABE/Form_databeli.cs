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
    public partial class Form_databeli : Form
    {
        public Form_databeli()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-5B0DFV64;Initial Catalog=tkbabe;User ID=sa;Password=Duaribu123");
        private void inputPembeliToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Form_menu().Show();
            this.Hide();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            new Form_inputbeli().Show();
            this.Hide();
        }

        private void Form_databeli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tkbabeDataSet2.Beli' table. You can move, or remove it, as needed.
            this.beliTableAdapter.Fill(this.tkbabeDataSet2.Beli);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                
                SqlCommand cmd = new SqlCommand(" Delete Beli where Id_beli=@Id_beli", con);

                con.Open();

                cmd.Parameters.AddWithValue("@Id_beli", int.Parse(textBox2.Text));
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show(" berhasil menghapus");
                Refreshtable();
            }
            void Refreshtable()
            {
                SqlCommand com = new SqlCommand("Select * From Beli", con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5B0DFV64;Initial Catalog=tkbabe;User ID=sa;Password=Duaribu123");
            SqlCommand cmd = new SqlCommand(" select * from Beli where Id_beli=@Id_beli", con);
            cmd.Parameters.AddWithValue("@Id_beli", int.Parse(textBox1.Text));


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
