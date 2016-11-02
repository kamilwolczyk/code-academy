using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex3.RegistrationForm
{
    class ConsoleManager
    {
        
        public int ChooseOption()
        {
            Console.WriteLine("[1] Zaloguj");
            Console.WriteLine("[2] Zarejestruj");
            Console.WriteLine("[3] Wyjdź");
            return Console.Read();
        }

        public User InputCredentials()
        {
            User _user = new User();
            Console.WriteLine("Input login: ");
            _user.Login = Convert.ToString(Console.Read());
            Console.WriteLine("Input password: ");
            _user.Password = Convert.ToString(Console.Read());
            return _user;
        }
    }
}
