using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Radek.Ex3.RegistrationForm
{
    class InMemoryUserRepository : IUserRepository
    {
        private Dictionary<string, Credentials> cred;
        
        public InMemoryUserRepository()
        {
            cred = new Dictionary<string, Credentials>();
        }

        public bool IsLogin(string login)
        {
            Credentials value;
            return cred.TryGetValue(login, out value);
        }

        public void Add(string login, string pass)
        {
            cred.Add(login, new Credentials(login, pass));

        }

        public bool Log(string login, string pass)
        {
            Credentials value;
            cred.TryGetValue(login, out value);
            return (value != null) ? (value.getPassword() == pass) : false;
        }
    }
}
