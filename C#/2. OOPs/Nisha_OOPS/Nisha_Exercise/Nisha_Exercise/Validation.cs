using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nisha_Exercise
{
    public class Validation
    {
        private UsersLogin user = null;
        private UsersLogin loggedInUser = null;


        public bool Register(string username, string pwd)
        {
            if (user == null)
            {
                user = new UsersLogin(username, pwd);
                return true;
            }
            Console.WriteLine("Can't register!..");
            return false;

        }

        public bool Login(string username, string pwd)
        {
            if (user != null && user.Username==username && user.PasswordValidate(pwd))
            {
                loggedInUser = user;
                return true;
            }
            Console.WriteLine("Invalid login");
            return false;

        }


        public void Logout()
        {
            if (loggedInUser != null)
            {
                Console.WriteLine($"User {loggedInUser.Username} logout..");
                loggedInUser = null;
            }
            

        }
    }
}
