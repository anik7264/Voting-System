using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Jahangirnagar_University
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string userName = txtusername.Text;
            MySqlConnection con = new MySqlConnection("datasource= localhost; database=voter;port=3306; username = root;"); //open connection
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from users where username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text + "'", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            { 
                if (userName == "anik") {
                    MessageBox.Show("Password Correct");
                    this.Hide();
                    step2 view2 = new step2();
                    view2.Show();
                }
                else if (userName == "admin")
                {
                    MessageBox.Show("Password Correct");
                    this.Hide();
                    step22 view2 = new step22();
                    view2.Show();
                }
            }
            else
            {
                MessageBox.Show("Username or password incorrect");
                reader.Close();
                txtusername.Text = string.Empty;
                txtpassword.Text = string.Empty;
                cmd.Dispose();
                con.Close();
            }
        }
    }

}
