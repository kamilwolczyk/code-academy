using System;

namespace Hc.Kamil.Ex1.Interfaces.Animals
{
    public class Sheep : Animal, ISound
    {
        public Sheep(string name) : base(name)
        { }

        public void MakeNoise()
        {
            Console.WriteLine($"{GetGreeting()}, Bee Bee Bee.");
        }
    }
}