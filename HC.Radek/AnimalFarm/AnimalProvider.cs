using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class AnimalProvider
    {
        private List<Animal> animals;
        private AnimalFactory animalFactory;

        public AnimalProvider()
        {
            animals = new List<Animal>();
            animalFactory = new AnimalFactory();
            generateAnimals(setUpListOfSpecies());
        }

        private List<AnimalSet> setUpListOfSpecies()
        {
            var animalSet = new List<AnimalSet>();
            animalSet.Add(new AnimalSet("Cat", "Insert number of cats: "));
            animalSet.Add(new AnimalSet("Dog", "Insert number of dogs: "));
            animalSet.Add(new AnimalSet("Cow", "Insert number of cows: "));
            animalSet.Add(new AnimalSet("Sheep", "Insert number of sheeps: "));
            return animalSet;
        }

        private void generateAnimals(List<AnimalSet> animalList)
        {
            foreach(var animalSet in animalList)
            {
                generateSingleSpeciesByAnimalSet(animalSet);
            }
        }

        private void generateSingleSpeciesByAnimalSet(AnimalSet animalSet)
        {
            try
            {
            Console.Write(animalSet.getQuestion());
            generateAnimalsFromSingleSpecies(animalSet.getSpecies());
            Console.WriteLine();
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Only numbers!");
                generateSingleSpeciesByAnimalSet(animalSet);
            }
        }
        
        private void generateAnimalsFromSingleSpecies(String species)
        {
            var number = Int32.Parse(Console.ReadLine());
            IterateAnimals(species, number);
            
        }

        private void IterateAnimals(String species, int number)
        {
            for (int i = 0; i < number; i++)
            {
                if(!setName(species)) i--;              
            }
        }

        private bool setName(String species)
        {
            Console.Write(species + " name: ");
            var name = Console.ReadLine();
            if (name != "")
            {
                animals.Add(animalFactory.getAnimal(species, name));
                return true;
            }
            else
            {
                Console.WriteLine("This " + species + " needs name!");
                return false;
            }
        }

        public List<Animal> getAnimals()
        {
            return animals;
        }

        private class AnimalSet
        {
            private String species;
            private String question;

            public AnimalSet(String species, String question)
            {
                this.species = species;
                this.question = question;
            }

            public String getQuestion()
            {
                return question;
            }

            public String getSpecies()
            {
                return species;
            }


        }
    }

    


    
}
