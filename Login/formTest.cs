﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class formTest : Form
    {
        public formTest(string fullname)
        {
            InitializeComponent();
            this.Text = "Xin chào " + fullname;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formTest_Load(object sender, EventArgs e)
        {

        }
    }
}
