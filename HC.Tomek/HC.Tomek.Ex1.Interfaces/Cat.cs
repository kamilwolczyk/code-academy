using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex1.Interfaces
{
    class Cat : IAnimal
    {
        private string _name;
        public Cat(string _name)
        {
            Name = _name;
        }
        public string Noise()
        {
            return "Miauuuu";
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
