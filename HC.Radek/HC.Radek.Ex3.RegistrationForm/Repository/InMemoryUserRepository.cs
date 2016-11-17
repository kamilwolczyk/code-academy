using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Radek.Ex3.RegistrationForm
{
    class InMemoryUserRepository : Repository.BaseRepository, IUserRepository
    {
        
        public InMemoryUserRepository()
        {
            cred = new Dictionary<string, Credentials>();
        }

    }
}
