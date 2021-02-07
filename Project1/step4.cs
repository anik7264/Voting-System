using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicLayer.Interface;
using LogicLayer.Implementation;

namespace Project1
{
    public partial class step4 : Form
    {
        IVotingManagement _votingManagement;
        public step4()
        {
            InitializeComponent();
            _votingManagement = new VotingManagement();
        }

        private void ConfirmButton4_Click(object sender, EventArgs e)
        {
            bool [] candidatesInUI = { AcheckBox4.Checked, BcheckBox4.Checked, CcheckBox4.Checked, DcheckBox4.Checked };
            int selectedCandidate;
            for(int i = 0; i < candidatesInUI.Length; i++){
                if(candidatesInUI[i]){
                    selectedCandidate = i+1;
                    break;
                }
                if(i >= candidatesInUI.Length - 1){ return; }
            }
            _votingManagement.SubmitVote(candidateId : 5, voterId: "voterId");
            MessageBox.Show("Thanks You for Voting");
            PrintPreview4.Document = PrintDocument4;
            PrintPreview4.ShowDialog();
            PrintDocument4.Print();
            step2 ss = new step2();
            ss.Show();
            this.Hide();
            
        }

        private void BackButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            step3 ss = new step3();
            ss.Show();
        }

        private void PrintDocument4_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(" Thanks For Your Voting", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 180));
        }

        private void AcheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (AcheckBox4.Checked == true)
            {
                AcheckBox4.Checked = true;
                BcheckBox4.Checked = false;
                CcheckBox4.Checked = false;
                DcheckBox4.Checked = false;
            }

        }

        private void BcheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (BcheckBox4.Checked == true)
            {
                BcheckBox4.Checked = true;
                AcheckBox4.Checked = false;
                CcheckBox4.Checked = false;
                DcheckBox4.Checked = false;
            }
        }

        private void CcheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (CcheckBox4.Checked == true)
            {
                CcheckBox4.Checked = true;
                BcheckBox4.Checked = false;
                AcheckBox4.Checked = false;
                DcheckBox4.Checked = false;
            }
        }

        private void DcheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (DcheckBox4.Checked == true)
            {
                DcheckBox4.Checked = true;
                BcheckBox4.Checked = false;
                CcheckBox4.Checked = false;
                AcheckBox4.Checked = false;
            }
        }

        private void step4_Load(object sender, EventArgs e)
        {

        }
    }
}
