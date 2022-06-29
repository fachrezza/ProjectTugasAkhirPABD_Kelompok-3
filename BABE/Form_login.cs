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
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (textUserName.Text == "Babe" && textPassword.Text == "123")
                {
                    new Form_menu().Show();
                    this.Hide();
                }
                else if (textUserName.Text == "Babeadmin" && textPassword.Text == "123")
                {
                    new Form_menu().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("the username of password you entered in incorrect, try again");
                    textUserName.Clear();
                    textPassword.Clear();
                    textUserName.Focus();
                }
            }
        }
    }
}
