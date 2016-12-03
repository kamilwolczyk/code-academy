using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex4.CashDispenser
{
    public class CashDispenserProviderCommandResponse
    {
        public CashDispenserProviderCommandResponse(bool _isBalanceOK, Dictionary<int,int> _banknotesToWithdraw)
        {
            IsBalanceOK = _isBalanceOK;
            BanknotesToWithdraw = _banknotesToWithdraw;
        }
        public bool IsBalanceOK {get; set;}
        public Dictionary<int,int> BanknotesToWithdraw { get; set; }

    }
}
