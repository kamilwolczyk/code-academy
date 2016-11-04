using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Cat : Animal
    {
        public Cat(String name)
        {
            this.name = name;
            species = "Cat";
            sound = "Miauu";
        }
    }
}
