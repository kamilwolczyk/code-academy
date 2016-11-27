using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Radek.Ex3.RegistrationForm
{
    class FileUserRepository : Repository.BaseRepository, IUserRepository
    {
        private const string path = @"d:\temp\MyTest.txt";

        public FileUserRepository()
        {
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


        public override void Add(string login, string pass)
        {
            base.Add(login, pass);
            Save();
        }

        private void Save()
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
