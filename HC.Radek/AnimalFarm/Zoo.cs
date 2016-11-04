using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Zoo
    {
        private List<Animal> animals;

        public Zoo(List<Animal> animals)
        {
            this.animals = animals;
        }

        public void makeNoise()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine("Hello, my name is " + animal.getName() + ", " + animal.getSound());
            }

            Console.ReadLine();
        }
    }
}
