using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class View
    {
        public void MainSite()
        {
            Console.Clear();
            Console.WriteLine("What do you want?");
            Console.WriteLine("[1] Buy our product");
            Console.WriteLine("[2] Check our wharehouse state?");
            Console.WriteLine("[3] Add new product?");
            Console.WriteLine("[4] Leave?");
            Console.WriteLine("What do you want?");
        }

        public void Buy(Dictionary<string, Item> stock)
        {
            Console.Clear();
            Console.WriteLine("Select item: ");
            CheckStock(stock);
            Console.Write("Item name: ");
        }

        public void BuyNumber()
        {
            Console.Write("How many items: ");
        }

        public void OnWrongItemNumber()
        {
            Console.WriteLine("We don't have so many items on stock");
        }

        public void OnNoItem(string name)
        {
            Console.Write($"We don't have {name} on stock");
        }

        public void OnBuySuccess()
        {
            Console.Write("Ok. You bought it!");
        }

        public void Add(int stage)
        {
            if (stage == 0)
            {
                Console.Clear();
                Console.Write("Item: ");
            }
            else if(stage == 1)
            {
                Console.Write("Value: ");
            }else
            {
                Console.Write("Prize: ");
            }
        }

        public void CheckStock(Dictionary<string, Item> stock)
        {
            foreach(KeyValuePair<string, Item> entry in stock)
            {
                Console.WriteLine($"Item: {entry.Key} Prize: {entry.Value.GetPrize()} Available: {entry.Value.GetValue()}");
            }
        }
    }

}
