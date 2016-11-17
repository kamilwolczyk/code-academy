using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex3.RegistrationForm
{
    class Program
    {
        static void Main(string[] args)
        {
            //IUserRepository database = new InFileUserRepository();
            //IValidator validator = new Validator();

            //ConsoleManager konsola = new ConsoleManager();
            //konsola.SelectOption(new ConsoleManager(), database, validator);
            //Console.WriteLine("Press any key to exit.");
            MD5 md5Hash = MD5.Create();
            HashPassword hashpass = new HashPassword();
            Console.WriteLine(hashpass.GetMd5Hash(md5Hash, "tomek"));

            //foreach (User i in database.GetUsersList())
            //{
            //    Console.WriteLine($"Login: {i.Login} Password: {i.Password}");
            //}
            Console.ReadKey();
        }
    }
}
