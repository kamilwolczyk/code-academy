using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex4.CashDispenser.Repository
{
    interface IUserRepository
    {
        bool CheckUserCardNumber(int cardNumber);
        bool CheckCardPinNumber(int cardNumber, int pinNumber);
        bool CheckUserMoneyBalance(int cardNumber, int moneyAmount);
        bool DepleteUserMoneyBalance(int cardNumber, int moneyAmount);
    }
}
