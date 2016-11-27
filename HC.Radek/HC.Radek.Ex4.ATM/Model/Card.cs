using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Radek.Ex4.ATM.Model
{
    public class Card
    {
        public Card(int pin, int balance)
        {
            Pin = pin;
            Balance = balance;
        }

        public int Pin { get; set; }

        public int Balance { get; set; }
    }
}
