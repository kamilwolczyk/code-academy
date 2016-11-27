using HC.Radek.Ex4.ATM.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Radek.Ex4.ATM.Helper
{
    class SelectAmountDecision
    {
        private Dictionary<string, EAmountDecision> DecisionMap = new Dictionary<string, EAmountDecision>();

        public SelectAmountDecision()
        {
            DecisionMap.Add("1", EAmountDecision.k50);
            DecisionMap.Add("2", EAmountDecision.k100);
            DecisionMap.Add("3", EAmountDecision.k150);
            DecisionMap.Add("4", EAmountDecision.k200);
            DecisionMap.Add("5", EAmountDecision.k300);
            DecisionMap.Add("6", EAmountDecision.k500);
        }

        public EAmountDecision GetDecision(string decision)
        {
            EAmountDecision Retval;
            DecisionMap.TryGetValue(decision, out Retval);
            return Retval;
        }
    }
}
