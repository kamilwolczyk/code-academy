using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Radek.Ex3.RegistrationForm.Repository
{
    abstract class BaseRepository
    {

        protected IDictionary<string, Credentials> cred = new Dictionary<string, Credentials>();

        public bool IsLogin(string login)
        {
            Credentials value;
            return cred.TryGetValue(login, out value);
        }

        public bool Log(string login, string pass)
        {
            Credentials value;
            cred.TryGetValue(login, out value);
            return (value != null) ? (value.getPassword() == pass) : false;
        }

        public string GetPasswordByLogin(string login)
        {
            Credentials value;
            cred.TryGetValue(login, out value);
            return (value == null) ? "" : value.getPassword();
        }

        public virtual void Add(string login, string pass)
        {
            cred.Add(login, new Credentials(login, pass));

        }
    }
}
