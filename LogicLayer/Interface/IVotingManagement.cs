using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicLayer.Interface
{
    public interface IVotingManagement
    {
        void SubmitVote(int candidateId, string voterId);
    }
}
