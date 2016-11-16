using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex3.RegistrationForm
{
    public class User
    {
        
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public User()
        {

        }

        public string Login
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }
    }
}
