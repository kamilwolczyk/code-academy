using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class AnimalFactory
    {
        public Animal getAnimal(String species, String name)
        {
            switch (species)
            {
                case "Cat":
                    return new Cat(name);
                case "Dog":
                    return new Dog(name);
                case "Sheep":
                    return new Sheep(name);
                default:
                    return new Cow(name);
            }
        }
    }
}
