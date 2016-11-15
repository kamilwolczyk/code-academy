using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Radek.Ex3.RegistrationForm
{
    class ConsoleView
    {
        private Dictionary<string, Decision> DecisionMap = new Dictionary<string, Decision>();

        public ConsoleView()
        {
            DecisionMap.Add("1", Decision.Login);
            DecisionMap.Add("2", Decision.Register);

        }

        public void MainSite()
        {
            Console.Clear();
            Console.WriteLine("What do you want?");
            Console.WriteLine("[1] Login");
            Console.WriteLine("[2] Register");
        }

        public void RegisterLogin()
        {
            Console.Clear();
            Console.WriteLine("Enter login:");
        }

        public void RegisterPassword()
        {
            Console.Clear();
            Console.WriteLine("Enter password:");
        }

        public void Logged()
        {
            Console.Clear();
            Console.WriteLine("Logged");
        }

        public void NotLogged()
        {
            Console.Clear();
            Console.WriteLine("Not logged");
        }

        public void NotCorrect()
        {
            Console.Clear();
            Console.WriteLine("Credentials not correct");
        }

        public Decision GetDecision()
        {
            Decision Retval;
            DecisionMap.TryGetValue(Console.ReadLine(), out Retval);
            return Retval;
        }

        public void Wait()
        {
            Console.ReadKey();
        }

        

    }
}
