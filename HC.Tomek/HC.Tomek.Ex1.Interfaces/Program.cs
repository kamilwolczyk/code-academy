using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HC.Tomek.Ex1.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalsProvider = new AnimalProvider();
            var animals = animalsProvider.GenerateAnimals();
            var animalsSounds = new AnimalsSounds(animals);
            animalsSounds.MakeSomeNoise();
            
            Console.ReadKey();            
        }
    }
}
