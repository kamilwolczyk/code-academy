using HC.Radek.Ex4.ATM.DTO;
using HC.Radek.Ex4.ATM.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Radek.Ex4.ATM.View
{
    class ConsoleView
    {

        public EWelcomeScreenDecision WelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine("Witamy w bankomacie");
            Console.WriteLine("Wypłata gotówki - naciśnij [1]");
            return new WelcomeScreenDecision().GetDecision(Console.ReadLine());
        }

        public void EnterCard()
        {
            Console.Clear();
            Console.WriteLine("Włóż kartę");
            System.Threading.Thread.Sleep(1000);
            OnCardEntered();
        }

        private void OnCardEntered()
        {
            string Progress = "";
            for(int i=0; i < 15; i++)
            {
                Console.Clear();
                Console.WriteLine("Wkładamy kartę");
                Console.WriteLine(Progress);
                System.Threading.Thread.Sleep(200);
                Progress += ".";
            }
        }

        public EAmountDecision SelectAmount()
        {
            Console.Clear();
            Console.WriteLine("Wybierz kwotę:");
            Console.WriteLine("[1] 50 zł");
            Console.WriteLine("[2] 100 zł");
            Console.WriteLine("[3] 150 zł");
            Console.WriteLine("[4] 200 zł");
            Console.WriteLine("[5] 300 zł");
            Console.WriteLine("[6] 500 zł");
            return new SelectAmountDecision().GetDecision(Console.ReadLine());
        }

        public void OnWithdrawSuccess()
        {
            Console.Clear();
            Console.WriteLine("Kwota wypłacona");
            System.Threading.Thread.Sleep(3000);
        }

        public void OnWithdrawFailure()
        {
            Console.Clear();
            Console.WriteLine("Kwota nie wypłacona - brak środków");
            System.Threading.Thread.Sleep(3000);
        }

    }
}
