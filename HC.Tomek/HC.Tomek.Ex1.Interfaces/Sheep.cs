using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex1.Interfaces
{
    class Sheep : IAnimal
    {
        private string _name;
        public Sheep(string _name)
        {
            Name = _name;
        }
        public string Noise()
        {
            return "Bee Bee Bee";
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
