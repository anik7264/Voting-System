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
    public partial class step4 : Form
    {
        public step4()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            step3 ss = new step3();
            ss.Show();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {

            bool[] candidatesInUI = { AcheckBox1.Checked, BcheckBox2.Checked, CcheckBox3.Checked, DcheckBox4.Checked };
            int selectedCandidate;
            for (int i = 0; i < candidatesInUI.Length; i++)
            {
                if (candidatesInUI[i])
                {
                    selectedCandidate = i + 1;
                    break;
                }
                if (i >= candidatesInUI.Length - 1) { return; }
            }

            MessageBox.Show("Thanks You for Voting");
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            printDocument1.Print();
            step2 ss = new step2();
            ss.Show();
            this.Hide();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(" Thanks For Your Voting", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 180));
        }

        private void AcheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (AcheckBox1.Checked == true)
            {
                AcheckBox1.Checked = true;
                BcheckBox2.Checked = false;
                CcheckBox3.Checked = false;
                DcheckBox4.Checked = false;
            }

        }

        private void BcheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (BcheckBox2.Checked == true)
            {
                BcheckBox2.Checked = true;
                AcheckBox1.Checked = false;
                CcheckBox3.Checked = false;
                DcheckBox4.Checked = false;
            }
        }

        private void CcheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CcheckBox3.Checked == true)
            {
                CcheckBox3.Checked = true;
                BcheckBox2.Checked = false;
                AcheckBox1.Checked = false;
                DcheckBox4.Checked = false;
            }
        }

        private void DcheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (DcheckBox4.Checked == true)
            {
                DcheckBox4.Checked = true;
                BcheckBox2.Checked = false;
                CcheckBox3.Checked = false;
                AcheckBox1.Checked = false;
            }
        }
    }
}
