using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public abstract class Animal
    {
        protected string name;
        protected string species;
        protected string sound;

        public string getName()
        {
            return name;
        }

        public string getSpecies()
        {
            return species;
        }

        public string getSound()
        {
            return sound;
        }

    }
}
