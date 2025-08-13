using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nisha_Exercise
{
    public class UsersLogin
    {
        public string Username { get; private set; }
        private string _password;

        public UsersLogin(string user, string pwd)
        {
            Username = user;
            _password = pwd;
        }

        public bool PasswordValidate(string pwd)
        {
            return _password == pwd;
        }

    }
}
