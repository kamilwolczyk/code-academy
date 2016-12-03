using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex4.CashDispenser.Repository
{
    interface ICashRepository
    {
        bool DepleteBanknoteIfAvailable(int banknoteValue);
        Dictionary<int, int> GetAllBanknotes();


    }
}
