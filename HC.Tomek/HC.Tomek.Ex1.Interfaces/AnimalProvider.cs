using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.Tomek.Ex1.Interfaces
{
    class AnimalProvider
    {
    public enum Animalplural { cats, dogs, cows, sheeps }
    public enum Animalsingular { Cat, Dog, Cow, Sheep }
  
    public List<IAnimal> GenerateAnimals()
        {
            Type myType = typeof(AnimalProvider);
            string namespaceName = myType.Namespace; // it could be simpler: namespaceName="zoo";
            List<IAnimal> animals = new List<IAnimal>();
            
            for(int i=0; i<Enum.GetNames(typeof(Animalplural)).Length; i++)
            {
                int numberof=0;
                Console.Write($"Insert number of {(Animalplural)i}: ");
                try
                {
                    numberof = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Write($"Problem with integer format. No {(Animalplural)i} acquired.\n");
                }
                for(int j=0; j<numberof; j++)
                {
                    Console.Write($"{(Animalsingular)i} name: ");
                    animals.Add((IAnimal)Activator.CreateInstance(Type.GetType(namespaceName + "." + (Animalsingular)i), (Console.ReadLine()))); //create object using class name
                }
            }
            return animals;
        }
    }
}
