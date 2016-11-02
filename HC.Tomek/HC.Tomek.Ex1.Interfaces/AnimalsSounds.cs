using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex1.Interfaces
{
    class AnimalsSounds
    {
        private List<IAnimal> _animals;
        public AnimalsSounds(List<IAnimal> _animals)
        {
            Animals = _animals;
        }
        public List<IAnimal> Animals
        {
            get { return _animals; }
            set { _animals = value; }
        }
        public void MakeSomeNoise()
        {
            foreach(IAnimal i in Animals)
            {
                Console.WriteLine($"Hello, my name is {i.Name}, {i.Noise()}");
            }
        }
    }
}
