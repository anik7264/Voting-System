using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LogicLayer.Interface;
using Model;

namespace LogicLayer.Implementation
{
    public class UserAuthModule : IUserAuthModule
    {
        public bool LogIn(string userName, string passWord)
        {
            // this data will come from database
            Admin adminUser = new Admin { UserName = "admin", Password = "password" };
            if (adminUser.Password == passWord)
                return true;
            else
                return false;
        }
    }
}
