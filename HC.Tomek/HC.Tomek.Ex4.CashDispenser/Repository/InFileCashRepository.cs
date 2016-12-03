using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HC.Tomek.Ex4.CashDispenser.Repository
{
    class InFileCashRepository : ICashRepository
    {
        string path = @"..\..\use_me_txt\CashRepository.txt";
        Dictionary<int, int> _cashRepository = new Dictionary<int, int>();
        bool _banknoteDepleted = false;
        public bool DepleteBanknoteIfAvailable(int banknoteValue)
        {
            _cashRepository.Clear();
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    string[] _splittedstring = s.Split(',');
                    _cashRepository.Add(Convert.ToInt32(_splittedstring[0]), Convert.ToInt32(_splittedstring[1]));
                }
            }
                try
                {
                if (_cashRepository[banknoteValue] > 0)
                {
                    _cashRepository[banknoteValue] -= 1;
                    File.Delete(path);
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        foreach (KeyValuePair<int, int> i in _cashRepository)
                        {
                            sw.WriteLine(i.Key.ToString() + ',' + i.Value.ToString());
                        }
                        _banknoteDepleted = true;
                    }
                }
                }
                catch (Exception)
                {

                _banknoteDepleted=false;
                }
            return _banknoteDepleted;
        }
        public Dictionary<int,int> GetAllBanknotes()
        {
            Dictionary<int, int> _cashRepository = new Dictionary<int, int>();
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    string[] _splittedstring = s.Split(',');
                    _cashRepository.Add(Convert.ToInt32(_splittedstring[0]), Convert.ToInt32(_splittedstring[1]));
                }
            }
            return _cashRepository;
        }
    }
}
