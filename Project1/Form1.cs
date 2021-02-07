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
using LogicLayer.Interface;
using LogicLayer.Implementation;

namespace Project1
{
    public partial class Form1 : Form
    {
        private IUserAuthModule _userAuthModule;
        public Form1()
        {
            InitializeComponent();
            _userAuthModule = new UserAuthModule();
        }

        private void LoginButton1_Click(object sender, EventArgs e)
        {
            string userName = UsertextBox1.Text;
            string pass = PasstextBox1.Text;
            if (_userAuthModule.LogIn(userName, pass))
            {
                this.Hide();
                step2 view2 = new step2();
                view2.Show();
            }
            else
            {
                UsertextBox1.Clear();
                PasstextBox1.Clear();
            }
        }

        private void ExitButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
