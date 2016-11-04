using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Dog : Animal
    {
        public Dog(String name)
        {
            this.name = name;
            species = "Dog";
            sound = "Hau Hau";
        }
    }
}
