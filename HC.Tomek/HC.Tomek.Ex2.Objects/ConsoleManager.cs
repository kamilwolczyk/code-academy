using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex2.Objects
{
    class ConsoleManager
    {
        public void DisplayOptions(Warehouse warehouse)
        {
            int option = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("[1] Buy our product");
                Console.WriteLine("[2] Check warehouse state");
                Console.WriteLine("[3] Add new product");
                Console.WriteLine("[4] Leave");
                Console.Write("Select: ");
                option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 1:
                        warehouse.BuyProduct(DefineProduct());
                        break;
                    case 2:
                        DisplayResources(warehouse);
                        break;
                    case 3:
                        warehouse.AddProduct(DefineProduct());
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("It's a typo I guess. Option 1-4 available.");
                        break;
                }
                Console.WriteLine("Click any key to return");
                Console.ReadKey();
            }
            while (option != 4);
        }

        public void DisplayResources(Warehouse warehouse)
        {
            string line = "---------------------------------";   //why I can't declare variable line as "private" here ??
            string header = "|                Name|Price|Count|";
            Console.WriteLine("PRODUCTS");
            Console.WriteLine(line);
            Console.WriteLine(header);
            Console.WriteLine(line);

            foreach (Product e in warehouse.GetList())
            {
                Console.WriteLine($"|\t\t{e.Name}|\t{e.Price}|\t{e.Count}|");

            }
            Console.WriteLine(line);
        }

        public Product DefineProduct()
        {
            var product = new Product();
            Console.Write("Name: ");
            product.Name = Console.ReadLine();
            Console.Write("Price: ");
            product.Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Count: ");
            product.Count = Convert.ToInt32(Console.ReadLine());
            return product;
        }
    }
}
