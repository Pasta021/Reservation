using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "demo" && textBox2.Text == "1234")
            {
                new main().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("The User name or password you entered is incorrect, try again");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }
    }
}
