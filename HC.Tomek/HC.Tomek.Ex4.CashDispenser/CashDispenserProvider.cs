using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HC.Tomek.Ex4.CashDispenser.Repository;

namespace HC.Tomek.Ex4.CashDispenser
{
    public class CashDispenserProvider
    {
        
        CashDispenserProviderCommandResponse _commandResponse = new CashDispenserProviderCommandResponse(new bool(), new Dictionary<int, int>());
        ICashRepository _cashRepo = new InFileCashRepository();
        public CashDispenserProviderCommandResponse CalculateMoney(int moneyAmount)
        {
            _commandResponse.IsBalanceOK = false;
            int _moneyAmount = moneyAmount;
            Dictionary<int,int> _cashDispenserBanknotes = _cashRepo.GetAllBanknotes();
            int _numberOfBanknotesTypes = _cashDispenserBanknotes.Count();
            int _banknoteValue = _cashDispenserBanknotes.Keys.Max();

            if (_moneyAmount % _cashDispenserBanknotes.Keys.Min() == 0)
            {
                for (int i = 0; i < _numberOfBanknotesTypes; i++)
                {

                    while ((_moneyAmount >= _banknoteValue) && (_cashDispenserBanknotes[_banknoteValue] > 0))
                    {
                        _moneyAmount = _moneyAmount - _banknoteValue;
                        _cashDispenserBanknotes[_banknoteValue] -= 1;
                        if (_commandResponse.BanknotesToWithdraw.ContainsKey(_banknoteValue))
                            _commandResponse.BanknotesToWithdraw[_banknoteValue] += 1;
                        else
                            _commandResponse.BanknotesToWithdraw.Add(_banknoteValue, 1);

                    }
                    if (_moneyAmount == 0) _commandResponse.IsBalanceOK = true;
                    else _cashDispenserBanknotes.Remove(_banknoteValue);
                    _banknoteValue = _cashDispenserBanknotes.Keys.Max();
                }
            }

            return _commandResponse;
        }
        public bool DepleteBanknotes(CashDispenserProviderCommandResponse banknotes)
        {
            bool _response = true;
            int _numberOfBanknotesTypes = banknotes.BanknotesToWithdraw.Count();
            int _banknoteValue = banknotes.BanknotesToWithdraw.Keys.Max();

            if (banknotes.IsBalanceOK == true)
            {
                for (int i = 0; i < _numberOfBanknotesTypes; i++)
                {
                    _banknoteValue = banknotes.BanknotesToWithdraw.Keys.Max();
                    while ((banknotes.BanknotesToWithdraw[_banknoteValue] > 0) && (_response == true))
                    {
                        _response=_cashRepo.DepleteBanknoteIfAvailable(_banknoteValue);
                        if (_response == true) banknotes.BanknotesToWithdraw[_banknoteValue] -= 1;
                    }
                    banknotes.BanknotesToWithdraw.Remove(_banknoteValue);
                   
                }
                _cashRepo.DepleteBanknoteIfAvailable(_banknoteValue);
            }
            return _response;
        }
    }
}
