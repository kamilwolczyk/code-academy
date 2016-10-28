using System;
using System.Collections.Generic;
using Hc.Kamil.Ex1.Interfaces.Animals;

namespace Hc.Kamil.Ex1.Interfaces
{
    public class AnimalsProvider
    {
        public IEnumerable<ISound> GenerateAnimals()
        {
            var animals = new List<ISound>();
            animals.AddRange(GenerateAnimalForSpecies<Cat>("cat"));
            animals.AddRange(GenerateAnimalForSpecies<Dog>("dog"));
            animals.AddRange(GenerateAnimalForSpecies<Cow>("cow"));
            animals.AddRange(GenerateAnimalForSpecies<Sheep>("sheep"));
            return animals;
        }

        private IEnumerable<ISound> GenerateAnimalForSpecies<TAnimal>(string animalName) where TAnimal : ISound
        {
            Console.Write($"Insert number of {animalName}s: ");
            var animalNumber = int.Parse(Console.ReadLine());
            var animals = new List<ISound>();

            for (var i = 0; i < animalNumber; i++)
            {
                Console.Write($"{animalName} name: ");
                var name = Console.ReadLine();

                animals.Add((TAnimal)Activator.CreateInstance(typeof(TAnimal), name));
            }
            Console.WriteLine();
            
            return animals;
        }
    }
}