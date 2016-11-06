using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex3.RegistrationForm
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleManager konsola = new ConsoleManager();
            UserDatabase database = new UserDatabase();
            konsola.SelectOption(new ConsoleManager(), database);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
