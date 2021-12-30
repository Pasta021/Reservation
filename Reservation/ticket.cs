using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation
{
    public partial class ticket : Form
    {
        public ticket()
        {
            InitializeComponent();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Name field is empty");
                textBox1.Focus();
            }
            else if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("ID field is empty");
                textBox2.Focus();
            }
            
            else if (textBox5.Text.Equals(""))
            {
                MessageBox.Show("Price field is empty");
                textBox5.Focus();
            }
            else if (textBox6.Text.Equals(""))
            {
                MessageBox.Show("Total Price field is empty");
                textBox6.Focus();
            }
            else if (comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Please Select a Age Group");
                textBox6.Focus();
            }
            else if (comboBox2.Text.Equals(""))
            {
                MessageBox.Show("Please Select a group of people");
                textBox6.Focus();
            }
            else if (comboBox3.Text.Equals(""))
            {
                MessageBox.Show("Please Select a Total Hours");
                textBox6.Focus();
            }
            else
            {
                string FileName = @"C:\Users\sujan\source\repos\Reservation\data\visitor.csv";
                if (!File.Exists(FileName))
                {
                    string HeaderText = "Name" + "," + "ID" + "," + "In Time" + "," + "Out Time" + "," + "Ticket Price" + "," + "Total Price"+ "," + "Age Group" + "," + "Group Of people" + "," + "Total Hours" +Environment.NewLine;
                    File.WriteAllText(FileName, HeaderText);
                }
                string clientDetails = textBox1.Text + ", " + textBox2.Text + ", " + textBox3.Text + ", " + textBox4.Text + ", " + textBox5.Text + ", " + textBox6.Text + ", " + comboBox1.Text + ", " + comboBox2.Text + ", " + comboBox3.Text + "\n";
                File.AppendAllText(FileName, clientDetails);
                MessageBox.Show("Data Inserrted");
            }
        }
    }
}
