using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Sheep : Animal
    {
        public Sheep(String name)
        {
            this.name = name;
            species = "Sheep";
            sound = "Beeee";
        }
    }
}
