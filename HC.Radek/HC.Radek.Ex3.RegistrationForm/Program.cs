using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Radek.Ex3.RegistrationForm
{
    class Program
    {
        static void Main(string[] args)
        {
            //new MainController(new Validator(), new InMemoryUserRepository(), new ConsoleView()).MainSite();
            MainController Controller = new MainController(new Validator(), new FileUserRepository(), new ConsoleView());
            Controller.setPasswordEncryption(new PasswordEncryption());
            Controller.MainSite();

            
        }
    }
}
