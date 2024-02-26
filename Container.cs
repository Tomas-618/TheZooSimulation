using System;
using System.Collections.Generic;
using System.Linq;

namespace TheZooSimulation
{
    public class Container
    {
        private Dictionary<Type, Func<Gender, Animal>> _animals;

        public Container() =>
            _animals = FillAnimalsMap();

        public List<Aviary> CreateAviaries()
        {
            List<Type> animalTypes = _animals.Keys
                .ToList();

            List<Aviary> aviaries = new List<Aviary>();

            int minAviariesCount = 4;
            int maxAviariesCount = animalTypes.Count;

            int aviariesCount = Utils.GetRandomNumber(minAviariesCount, maxAviariesCount + 1);

            for (int i = 0; i < aviariesCount; i++)
            {
                int minAnimalsCount = 2;
                int maxAnimalsCount = 8;

                int animalTypeIndex = Utils.GetRandomNumber(animalTypes.Count);
                int animalsCount = Utils.GetRandomNumber(minAnimalsCount, maxAnimalsCount + 1);

                List<Animal> animals = CreateAnimals(animalTypes[animalTypeIndex], animalsCount);

                aviaries.Add(new Aviary(animals));
                animalTypes.RemoveAt(animalTypeIndex);
            }

            return aviaries;
        }

        private List<Animal> CreateAnimals(Type animalType, in int count)
        {
            List<Animal> animals = new List<Animal>();

            for (int i = 0; i < count; i++)
            {
                Gender[] genderTypes = Enum.GetValues(typeof(Gender))
                    .Cast<Gender>()
                    .ToArray();

                int genderIndex = Utils.GetRandomNumber(genderTypes.Length);

                animals.Add(_animals[animalType]?.Invoke(genderTypes[genderIndex]));
            }

            return animals;
        }

        private Dictionary<Type, Func<Gender, Animal>> FillAnimalsMap()
        {
            return new Dictionary<Type, Func<Gender, Animal>>
            {
                [typeof(Zebra)] = gender => new Zebra(gender),
                [typeof(Parrot)] = gender => new Parrot(gender),
                [typeof(Monkey)] = gender => new Monkey(gender),
                [typeof(Lemur)] = gender => new Lemur(gender),
                [typeof(Hippopotamus)] = gender => new Hippopotamus(gender),
                [typeof(Crocodile)] = gender => new Crocodile(gender),
                [typeof(Tiger)] = gender => new Tiger(gender),
                [typeof(Lion)] = gender => new Lion(gender),
            };
        }
    }
}
