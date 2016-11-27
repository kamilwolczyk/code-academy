using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HC.Radek.Ex4.ATM.Model;
using System.IO;
using HC.Radek.Ex4.ATM.Helper;

namespace HC.Radek.Ex4.ATM.Repository
{
    class CardRepository : ICardRepository
    {
        private const string path = @"d:\temp\Cards.txt";
        protected IDictionary<int, Card> cards = new Dictionary<int, Card>();

        public CardRepository()
        {
            // Open the file to read from.
            if (File.Exists(path))
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] split = s.Split(";".ToCharArray());
                        cards.Add(Int32.Parse(split[0]), CardFactory.GetCard(Int32.Parse(split[0]), Int32.Parse(split[1])));
                    }
                }
            }
        }

        public Card GetCardByPin(int pin)
        {
            Card value;
            cards.TryGetValue(pin, out value);
            return value;
        }

        public void Save()
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (KeyValuePair<int, Card> singleCredential in cards)
                {
                    sw.WriteLine(singleCredential.Value.Pin + ";" + singleCredential.Value.Balance);
                }
            }
        }

        public void SetCardBalanceByPin(int pin, int balance)
        {
            cards.Add(pin, CardFactory.GetCard(pin, balance));
            Save();
        }
    }
}
