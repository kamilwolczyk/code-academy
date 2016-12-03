using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HC.Tomek.Ex4.CashDispenser.Repository;

namespace HC.Tomek.Ex4.CashDispenser
{
    class Program
    {
        static void Main(string[] args)
        {

            CashDispenserManager manager = new CashDispenserManager();
            manager.StartCashDispenserProcess();
        }
    }
}
