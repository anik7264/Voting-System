using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Vote
    {
        public int VoteId { get; set; }
        public int CandidateId { get; set; }
        public string VoterId { get; set; }
        public DateTime ViteTime { get; set; }
    }
}
