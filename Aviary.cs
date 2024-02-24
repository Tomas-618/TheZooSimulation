using System.Collections.Generic;
using System.Linq;

namespace TheZooSimulation
{
    public class Aviary
    {
        private List<Animal> _animals;

        public Aviary(AnimalType type) =>
            _animals = GetAnimals(type);

        public override string ToString()
        {
            string result = $"Type: {_animals.First().Type} || Sound: {_animals.First().Sound}\n";

            for (int i = 0; i < _animals.Count; i++)
            {
                int index = i + 1;

                result += $"{index}) {_animals[i]}\n";
            }

            return result;
        }

        private List<Animal> GetAnimals(AnimalType type)
        {
            List<Animal> animals = new List<Animal>();

            int minAnimalsCount = 1;
            int maxAnimalsCount = 8;

            int animalsCount = Utils.GetRandomNumber(minAnimalsCount, maxAnimalsCount);

            for (int i = 0; i < animalsCount; i++)
            {
                int animalGender = Utils.GetRandomNumber(1);

                animals.Add(new Animal(type, (Gender)animalGender));
            }

            return animals;
        }
    }
}
