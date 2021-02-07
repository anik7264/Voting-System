using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicLayer.Implementation;
using LogicLayer.Interface;

namespace Project1
{
    public partial class step3 : Form
    {
        IFingerprintData _fingerprintData;
        public step3()
        {
            InitializeComponent();
            _fingerprintData = new FingerprintData();
        }

        private void ConfirmButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            step4 ss = new step4();
            ss.Show();
        }

        private void BackButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            step2 ss = new step2();
            ss.Show();
        }

        private void FingerButton3_Click(object sender, EventArgs e)
        {
            var voterData = _fingerprintData.GetVoterDataByFingerprintId("fingerprintID");
            IdtextBox3.Text = voterData.VoterId;
            NametextBox3.Text = voterData.Name;
            if (voterData.DateOfBirth != null)
                DatetextBox3.Text = voterData.DateOfBirth.ToString();
            else
                DatetextBox3.Text = "";
            BloodtextBox3.Text = voterData.BloodGroup;
            pictureBox1.ImageLocation = voterData.ImageUrl;
        }

    }
}
