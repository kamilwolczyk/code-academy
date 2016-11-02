using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex2.Objects
{
    class Product
    {
        
        public Product(string name, double price, int count) // tutaj parametry wejsciowe: name, price i count żyją w ramach konstruktora
        {
            Name = name;
            Price = price;
            Count = count;

        }
        public Product()
        {

        }
        public string Name
        {
            get;
            set;
        }
        public double Price
        {
            get;
            set;
        }
        private int ble; // ten zapis jest nadmiarowy - zostawiam tak do celów edukacyjnych
        public int Count
        {
            get { return ble; }
            set { ble = value; }
        }
    }
}
