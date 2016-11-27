using HC.Radek.Ex4.ATM.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Radek.Ex4.ATM.Helper
{
    class WelcomeScreenDecision
    {
        private Dictionary<string, EWelcomeScreenDecision> DecisionMap = new Dictionary<string, EWelcomeScreenDecision>();

        public WelcomeScreenDecision()
        {
            DecisionMap.Add("1", EWelcomeScreenDecision.Withdraw);
        }

        public EWelcomeScreenDecision GetDecision(string decision)
        {
            EWelcomeScreenDecision _retval;
            DecisionMap.TryGetValue(decision, out _retval);
            return _retval;
        }
    }
}
