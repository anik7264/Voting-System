using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Voter
    {
        public string VoterId { get; set; }
        public int FingerprintId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BloodGroup { get; set; }
        public string ImageUrl { get; set; }
    }
}
