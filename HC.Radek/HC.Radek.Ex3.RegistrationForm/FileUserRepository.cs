using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Radek.Ex3.RegistrationForm
{
    class FileUserRepository : IUserRepository
    {
        private string path = @"d:\temp\MyTest.txt";
        private IDictionary<string, Credentials> cred;

        public FileUserRepository()
        {
            cred = new Dictionary<string, Credentials>();
            // Open the file to read from.
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] split = s.Split(";".ToCharArray());
                        cred.Add(split[0], new Credentials(split[0], split[1]));
                    }
                }
            }
        }
        

        public void Add(string login, string pass)
        {
            cred.Add(login, new Credentials(login, pass));
            Save();
        }

        public bool IsLogin(string login)
        {
            Credentials value;
            return cred.TryGetValue(login, out value);
        }

        public bool Log(string login, string pass)
        {
            Credentials value;
            cred.TryGetValue(login, out value);
            if (value != null)
            {
                return (value.getPassword() == pass);
            }
            else
            {
                return false;
            }
        }

        private void Save()
        {
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    foreach (KeyValuePair<string, Credentials> singleCredential in cred)
                    {
                        sw.WriteLine(singleCredential.Value.GetLogin() + ";" + singleCredential.Value.getPassword());
                    }
                }
            }
        }
    }
}
