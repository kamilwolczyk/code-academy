using HC.Radek.Ex4.ATM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Radek.Ex4.ATM.Helper
{
    class CardFactory
    {
        public static Card GetCard(int pin, int balance)
        {
            return new Card(pin, balance);
        } 
    }
}
