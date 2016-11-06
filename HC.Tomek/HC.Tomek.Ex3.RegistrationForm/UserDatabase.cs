using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex3.RegistrationForm
{
    public class UserDatabase
    {
        private List<User> database = new List<User>();

        public IEnumerable<User> GetUsersList()
        {
            return database;
        }

        public void AddUser(User user)
        {
            database.Add(user);
        }
    }
}
