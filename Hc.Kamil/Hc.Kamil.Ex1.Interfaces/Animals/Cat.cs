using System;

namespace Hc.Kamil.Ex1.Interfaces.Animals
{
    public class Cat : Animal, ISound
    {
        public Cat(string name) : base(name)
        { }

        public void MakeNoise()
        {
            Console.WriteLine($"{GetGreeting()}, Miauuuu.");
        }
    }
}