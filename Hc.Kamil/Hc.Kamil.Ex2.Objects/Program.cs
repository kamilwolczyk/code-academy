using Hc.Kamil.Ex2.Objects.UserInterface;
using System;

namespace Hc.Kamil.Ex2.Objects
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Introduction();
            IShop myShop = new Shop(new Salesman("Marek"), new StandardWarehouse());
            myShop.HandleCustomer();
        }

        private static void Introduction()
        {
            Console.WriteLine("Exercise 3 - Classes");
            Console.WriteLine("------------------------------------");
        }
    }
}