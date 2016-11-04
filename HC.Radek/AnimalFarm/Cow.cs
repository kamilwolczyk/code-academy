using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Cow : Animal
    {
        public Cow(String name)
        {
            this.name = name;
            species = "Cow";
            sound = "Muuuu";
        }
    }
}
