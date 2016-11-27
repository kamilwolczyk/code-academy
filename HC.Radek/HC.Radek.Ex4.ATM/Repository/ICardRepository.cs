using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Radek.Ex4.ATM.Repository
{
    interface ICardRepository
    {
        Model.Card GetCardByPin(int pin);
        void Save();
        void SetCardBalanceByPin(int pin, int balance);
    }
}
