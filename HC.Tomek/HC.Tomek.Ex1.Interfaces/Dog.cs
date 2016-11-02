using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex1.Interfaces
{
    class Dog : IAnimal
    {
        private string _name;
        public Dog(string _name)
        {
            Name = _name;
        }
        public string Noise()
        {
            return "Hau Hau Hau";
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
