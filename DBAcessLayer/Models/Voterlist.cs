using System;
using System.Collections.Generic;

#nullable disable

namespace DBAcessLayer.Models
{
    public partial class Voterlist
    {
        public int Voterid { get; set; }
        public string Votername { get; set; }
        public DateTime Voterdateofbirth { get; set; }
        public string Voterblood { get; set; }
        public int? Sl { get; set; }
    }
}
