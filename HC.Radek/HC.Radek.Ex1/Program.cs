﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalProvider = new AnimalProvider();
            var animals = animalProvider.getAnimals();
            new Zoo(animals).makeNoise();
        }
    }
}
