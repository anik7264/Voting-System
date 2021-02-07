using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicLayer.Interface
{
    public interface IUserAuthModule
    {
        bool LogIn(string userName, string passWord);
    }
}
