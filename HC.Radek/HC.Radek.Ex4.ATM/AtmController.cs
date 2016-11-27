using HC.Radek.Ex4.ATM.DTO;
using HC.Radek.Ex4.ATM.Helper;
using HC.Radek.Ex4.ATM.Model;
using HC.Radek.Ex4.ATM.Repository;
using HC.Radek.Ex4.ATM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Radek.Ex4.ATM
{
    class AtmController
    {
        ConsoleView consoleView;
        CardRepository cardRepository;
        Card cardMock;
        private IDictionary<EAmountDecision, int> amount;

        public AtmController(ConsoleView _consoleView, CardRepository _cardRepository)
        {
            consoleView = _consoleView;
            cardRepository = _cardRepository;

            cardMock = CardFactory.GetCard(1111, 350);

            amount = new Dictionary<EAmountDecision, int>();
            amount.Add(EAmountDecision.k50, 50);
            amount.Add(EAmountDecision.k100, 100);
            amount.Add(EAmountDecision.k150, 150);
            amount.Add(EAmountDecision.k200, 200);
            amount.Add(EAmountDecision.k300, 300);
            amount.Add(EAmountDecision.k500, 500);

        }

        public void WelcomeScreen()
        {
            EWelcomeScreenDecision decision = consoleView.WelcomeScreen();
            if(decision == EWelcomeScreenDecision.Withdraw)
            {
                EnterCard();
            }
        }

        public void EnterCard()
        {
            consoleView.EnterCard();
            SelectAmount();
        }

        public void SelectAmount()
        {
            EAmountDecision decision = consoleView.SelectAmount();
            if (decision == EAmountDecision.error)
            {
                SelectAmount();
            }else
            {
                OnSelectedAmount(decision);
            }
        }

        public void OnSelectedAmount(EAmountDecision decision)
        {
            Card enteredCard = cardRepository.GetCardByPin(cardMock.Pin);

            if (enteredCard.Balance > GetAmountByDecision(decision))
            {
                consoleView.OnWithdrawSuccess();
            }else
            {
                consoleView.OnWithdrawFailure();
            }

            WelcomeScreen();
        }

        private int GetAmountByDecision(EAmountDecision decision)
        {
            int _retval;
            amount.TryGetValue(decision, out _retval);
            return _retval;
        }
    }
}
