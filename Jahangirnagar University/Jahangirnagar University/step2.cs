﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jahangirnagar_University
{
    public partial class step2 : Form
    {
        public step2()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            step3 ss = new step3();
            ss.Show();
        }
    }
}
