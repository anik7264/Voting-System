using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace LogicLayer.Interface
{
    public interface IFingerprintData
    {
        Voter GetVoterDataByFingerprintId(string fingerprintId);
    }
}
