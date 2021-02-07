using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicLayer.Interface;
using Model;

namespace LogicLayer.Implementation
{
    public class FingerprintData : IFingerprintData
    {
        public Voter GetVoterDataByFingerprintId(string fingerprintId)
        {
            Voter voter = new Voter();
            voter.Name = "Nafis Sadik";
            //voter.DateOfBirth = new DateTime.Now;
            voter.BloodGroup = "A+";
            voter.ImageUrl = "https://mlnet.gallerycdn.vsassets.io/extensions/mlnet/modelbuildergpu/16.1.1.2041102/1597186712350/Microsoft.VisualStudio.Services.Icons.Default";
            voter.VoterId = "46456484978216548";
            return voter;
        }
    }
}
