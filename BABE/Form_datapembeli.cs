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
    public partial class Form_datapembeli : Form
    {
        public Form_datapembeli()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            new Form_menu().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form_inputpembeli().Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Form_inputpembeli().Show();
            this.Hide();
        }

        private void Form_datapembeli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tkbabeDataSet.Pembeli' table. You can move, or remove it, as needed.
            this.pembeliTableAdapter.Fill(this.tkbabeDataSet.Pembeli);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5B0DFV64;Initial Catalog=tkbabe;User ID=sa;Password=Duaribu123");
            SqlCommand cmd = new SqlCommand(" Delete Pembeli where Id_pembeli=@Id_pembeli", con);

            con.Open();

            cmd.Parameters.AddWithValue("@Id_pembeli", int.Parse(textBox2.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show(" berhasil menghapus");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-5B0DFV64;Initial Catalog=tkbabe;User ID=sa;Password=Duaribu123");
            SqlCommand cmd = new SqlCommand(" select * from Pembeli where Id_pembeli=@Id_pembeli", con);
            cmd.Parameters.AddWithValue("@Id_pembeli", int.Parse(textBox1.Text));


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
