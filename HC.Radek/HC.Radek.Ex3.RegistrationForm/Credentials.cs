using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Radek.Ex3.RegistrationForm
{
    class Credentials
    {
        private string login;
        private string password;

        public Credentials(string _login, string _password)
        {
            login = _login;
            password = _password;
        }

        public string GetLogin()
        {
            return login;
        }

        public string getPassword()
        {
            return password;
        }

    }
}
