using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Model
    {
        private Dictionary<string, Item> stock;
        private Dictionary<string, Item> basket;

        public Model()
        {
            stock = new Dictionary<string, Item>();
            basket = new Dictionary<string, Item>();

        }

        public Dictionary<string, Item> GetStock()
        {
            return stock;
        }

        public Dictionary<string, Item> GetBasket()
        {
            return basket;
        }

        public Item GetItemFromStock(string item)
        {
            Item value = null;
            if (!stock.TryGetValue(item, out value)) {
                value = new Item(0, 0);
            }
            return value;
        }

        public Item GetItemFromBasket(string item)
        {
            Item value = null;
            if (!basket.TryGetValue(item, out value))
            {
                value = new Item(0, 0);
            }
            return value;
        }

        public void AddItemToStock(string item, int value, int prize)
        {
            var current = GetItemFromStock(item);
            current.SetValue(current.GetValue() + value);
            current.SetPrize(prize);
            if (!stock.ContainsKey(item)){
                stock.Add(item, current);
            }else
            {
                stock.Remove(item);
                stock.Add(item, current);
            }
        }

        public void AddItemToBasket(string item, int value)
        {
            var current = GetItemFromBasket(item);
            current.SetValue(current.GetValue() + value);
            basket.Add(item, current);
        }

    }
}
