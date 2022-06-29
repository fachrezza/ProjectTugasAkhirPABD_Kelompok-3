using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BABE
{
    public partial class Form_menu : Form
    {
        public Form_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form_datapembeli().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form_databarang().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form_databeli().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form_datatransaksi().Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            new Form_login().Show();
            this.Hide();
        }
    }
}
