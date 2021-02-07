using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicLayer.Interface;
using Model;

namespace LogicLayer.Implementation
{
    public class VotingManagement : IVotingManagement
    {
        public void SubmitVote(int candidateId, string voterId)
        {
            Vote vote = new Vote();
            vote.CandidateId = candidateId;
            vote.VoterId = voterId;
            // Submit data to database
        }
    }
}
