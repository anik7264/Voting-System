using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Jahangirnagar_University
{
    public partial class step3 : Form
    {
        public step3()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        { 
                this.Hide();
                step2 ss = new step2();
                ss.Show();
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            step4 ss = new step4();
            ss.Show();
        }

        private void fingerbutton_Click(object sender, EventArgs e)
        {
            string votername = txtname.Text;
            string voterid = txtid.Text;
            string voterblood = txtblood.Text;
            string voterdateofbirth = txtdate.Text;
            string sl = txtsl.Text;
            MySqlConnection con = new MySqlConnection("datasource= localhost; database=voter;port=3306; username = root; password= tiger"); //open connection
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from voterlist where votername = '" + txtname.Text + "',voterid = '"+ txtid+"', dateofbirth = '"+txtdate+"', bloodgroup = '"+txtblood+"' AND sl = '" + txtsl.Text + "'", con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())               
            {
                txtname.Text = votername;
                txtid.Text = voterid;
                txtblood.Text = voterblood;
                txtdate.Text = voterdateofbirth;
            }
        }
    }
}
