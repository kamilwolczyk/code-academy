using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace HC.Tomek.Ex3.RegistrationForm
{
    class InFileUserRepository : IUserRepository
    {
        private List<User> database = new List<User>();
        private const string path = @"c:\temp\MyTest.txt";
        SHA512 sha512Hash = SHA512.Create();
        HashPassword hashpass = new HashPassword();

        public IEnumerable<User> GetUsersList()
        {
            return database;
        }

        public void AddUser(User user)
        {
            //database.Add(user);
            user.Password = hashpass.GetHash(sha512Hash, user.Password);
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(user.Login+","+user.Password);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(user.Login + "," + user.Password);
                }
            }
            ReadUser();
        }


        public void ReadUser()
        {
            database.Clear();
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    string[] stable;
                    while ((s = sr.ReadLine()) != null)
                    {
                        stable = s.Split(',');
                        database.Add(new User(stable[0], stable[1]));
                    }
                    Console.WriteLine(s);
                }
            }
            else
            {
                using (StreamWriter sw = File.CreateText(path));
            }
        }

    }
}
