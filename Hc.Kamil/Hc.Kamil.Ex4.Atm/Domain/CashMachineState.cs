using System;
using System.Collections.Generic;
using System.Linq;

namespace Hc.Kamil.Ex4.Atm.Domain
{
    public class CashMachineState
    {
        private readonly IDictionary<BankNoteType, int> _cash;

        public CashMachineState()
        {
            _cash = new Dictionary<BankNoteType, int>();
        }

        public int TotalMoney
        {
            get { return _cash.Sum(item => (int)item.Key * item.Value); }
        }

        public void AddMoney(IDictionary<BankNoteType, int> cash)
        {
            foreach (var pair in cash)
            {
                if (_cash.ContainsKey(pair.Key))
                    _cash[pair.Key] += pair.Value;
                else
                    _cash.Add(pair);
            }
        }

        public IDictionary<BankNoteType, int> GetMoney(int sum)
        {
            if (sum > TotalMoney)
                throw new InvalidOperationException("Cash machine does not have enought money for this operation.");

            var backup = new Dictionary<BankNoteType, int>(_cash);
            var stack = new Dictionary<BankNoteType, int>();
            
            //todo

            return stack;
        }
    }
}