using HC.Radek.Ex4.ATM.Repository;
using HC.Radek.Ex4.ATM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Radek.Ex4.ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            AtmController atmC = new AtmController(new ConsoleView(), new CardRepository());
            atmC.WelcomeScreen();
        }
    }
}
