﻿using System;
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
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            new main().Show();
            this.Hide();
        }
    }
}
