using HC.Tomek.Ex4.CashDispenser.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex4.CashDispenser
{
    public class CashDispenserManager
    {
        public void StartCashDispenserProcess()
        {
            bool _doTransaction = true;
            while (_doTransaction == true)
            {
                CashDispenserView _view = new CashDispenserView();
                IUserRepository _userRepo = new InFileUserRepository();
                CashDispenserProvider _cashProvider = new CashDispenserProvider();
                CashDispenserProviderCommandResponse _response = new CashDispenserProviderCommandResponse(new bool(), new Dictionary<int, int>());


                int cardNumber = _view.GetUserCardNumber();
                if (_userRepo.CheckUserCardNumber(cardNumber))
                {
                    int pinNumber = _view.GetCardPinNumber();
                    if (_userRepo.CheckCardPinNumber(cardNumber, pinNumber))
                    {
                        int moneyAmount = _view.GetMoneyAmount();
                        if (_userRepo.CheckUserMoneyBalance(cardNumber, moneyAmount))
                        {
                            _response = _cashProvider.CalculateMoney(moneyAmount);
                            if (_response.IsBalanceOK == true)
                            {
                                _cashProvider.DepleteBanknotes(_response);
                                _userRepo.DepleteUserMoneyBalance(cardNumber, moneyAmount);
                                _view.TransactionSuccessful();
                            }
                            else
                                _view.WrongAmount();
                        }
                        else
                            _view.WrongAmount();

                    }
                 
                }
                _doTransaction = _view.NextTransaction();

            }
        }
        
    }
}
