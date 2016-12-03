using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HC.Tomek.Ex4.CashDispenser.Repository
{
    public class InFileUserRepository : IUserRepository
    {
        string path = @"..\..\use_me_txt\UserRepository.txt";
        

        public bool CheckUserCardNumber(int cardNumber)
        {
            bool isCardNumberOK = false;
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    string[] _splittedstring = s.Split(',');
                    if (Convert.ToInt32(_splittedstring[0]) == cardNumber) isCardNumberOK=true;
                }
            }
            return isCardNumberOK;
        }

        public bool CheckCardPinNumber(int cardNumber, int pinNumber)
        {
            bool isPinNumberOK = false;
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    string[] _splittedstring = s.Split(',');
                    if (Convert.ToInt32(_splittedstring[0]) == cardNumber)
                        if (Convert.ToInt32(_splittedstring[1]) == pinNumber) isPinNumberOK = true;
                }
            }
            return isPinNumberOK;
        }

        public bool CheckUserMoneyBalance(int cardNumber, int moneyAmount)
        {
            bool isUserMoneyBalanceOK = false;
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    string[] _splittedstring = s.Split(',');
                    if (Convert.ToInt32(_splittedstring[0]) == cardNumber)
                        if (Convert.ToInt32(_splittedstring[2]) >= moneyAmount) isUserMoneyBalanceOK = true;
                }
            }
            return isUserMoneyBalanceOK;
        }

        public bool DepleteUserMoneyBalance(int cardNumber, int moneyAmount)
        {
            bool balanceDepleted = false;
            bool _balanceDepleted = false;
            int fileLineNumber = 0;
            string[] fileContent = new string[100];
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    fileContent[fileLineNumber] = s;
                    string[] _splittedstring = s.Split(',');
                    if (Convert.ToInt32(_splittedstring[0]) == cardNumber)
                    {
                        _splittedstring[2] = (Convert.ToInt32(_splittedstring[2])-moneyAmount).ToString();
                        fileContent[fileLineNumber] = _splittedstring[0] +','+ _splittedstring[1] + ','+_splittedstring[2];
                        _balanceDepleted = true;
                    }
                    fileLineNumber++;
                }
            }
                if (_balanceDepleted == true)
                    File.Delete(path);
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        for (int i = 0; i < fileLineNumber; i++)
                        {
                            sw.WriteLine(fileContent[i]);
                        }
                    }
                    balanceDepleted = true;
                
            return balanceDepleted;
        }

            
    }

}



