using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HC.Tomek.Ex4.CashDispenser
{
    public class CashDispenserView
    {
        private int _cardNumber;
        private int _pinNumber;
        private int _moneyAmount;
        public int GetUserCardNumber()
        {
            Console.WriteLine("Insert card ...");
            Thread.Sleep(2000);
            Console.Write("Card number: ");
            _cardNumber = Convert.ToInt32(Console.ReadLine());
            return _cardNumber;
        }
        public int GetCardPinNumber()
        {
            Console.Write("Input PIN number: ");
            _pinNumber=Convert.ToInt32(Console.ReadLine());
            return _pinNumber;
        }
        public int GetMoneyAmount()
        {
            Console.Write("Money amount to withdraw (50, 100, 150 etc.): ");
            _moneyAmount = Convert.ToInt32(Console.ReadLine());
            return _moneyAmount;
        }
        public void TransactionSuccessful()
        {
            Console.WriteLine("Transaction successful");
        }
        public void WrongAmount()
        {
            Console.WriteLine("Wrong amount or not enough credit");
        }
        public bool NextTransaction()
        {
            bool _response = false;
            Console.Write("Next transaction? [y/n]: ");
            char _answer = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
            if (_answer == 'Y') _response = true; 
            return _response;
        }
    }
}
