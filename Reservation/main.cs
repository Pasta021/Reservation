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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void reportBTN_Click(object sender, EventArgs e)
        {
            new report().Show();
            this.Hide();
        }

        private void adminBTN_Click(object sender, EventArgs e)
        {
            new admin().Show();
            this.Hide();
        }

        private void ticketBTN_Click(object sender, EventArgs e)
        {
            new ticket().Show();
            this.Hide();
        }
    }
}
