using System;

namespace Hc.Kamil.Ex1.Interfaces
{
    public class Zoo
    {
        private readonly ISound[] _animals;

        public Zoo(ISound[] animals)
        {
            _animals = animals;
        }

        public void MakeSomeNoise()
        {
            foreach (var animal in _animals)
                animal.MakeNoise();

            Console.ReadKey();
        }
    }
}