using System;
using System.Collections.Generic;

namespace TheZooSimulation
{
    public class Aviary
    {
        private List<Animal> _animals;

        public Aviary(List<Animal> animals)
        {
            if (animals.Count == 0)
                throw new ArgumentOutOfRangeException($"{nameof(animals)}: {animals}");

            _animals = animals ?? throw new ArgumentNullException(nameof(animals));
        }

        public override string ToString()
        {
            string result = string.Empty;

            for (int i = 0; i < _animals.Count; i++)
            {
                int index = i + 1;

                result += $"{index}) {_animals[i]}\n";
            }

            return result;
        }
    }
}
