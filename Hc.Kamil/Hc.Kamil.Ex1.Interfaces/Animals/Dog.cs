using System;

namespace Hc.Kamil.Ex1.Interfaces.Animals
{
    public class Dog : Animal, ISound
    {
        public Dog(string name) : base(name)
        { }

        public void MakeNoise()
        {
            Console.WriteLine($"{GetGreeting()}, Hau Hau Hau.");
        }
    }
}