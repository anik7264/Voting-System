using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Project1
{
    public partial class step2 : Form
    {
        public step2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            step3 ss = new step3();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            step5 ss = new step5();
            ss.Show();
        }

        private void ExitButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
