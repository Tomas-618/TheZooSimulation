using System;
using System.Collections.Generic;
using System.Linq;

namespace TheZooSimulation
{
    public class Animals
    {
        private Dictionary<AnimalType, string> _sounds;

        public Animals() =>
            _sounds = InitialazeTypeMap();

        public IReadOnlyList<AnimalType> AvalaibleSounds => _sounds.Keys
            .ToArray();

        public string GetSound(AnimalType type)
        {
            if (_sounds.ContainsKey(type) == false)
                throw new ArgumentOutOfRangeException(type.ToString());

            return _sounds[type];
        }

        public AnimalType GetRandomType()
        {
            int index = Utils.GetRandomNumber(AvalaibleSounds.Count - 1);

            return AvalaibleSounds[index];
        }

        private Dictionary<AnimalType, string> InitialazeTypeMap()
        {
            return new Dictionary<AnimalType, string>
            {
                [AnimalType.Lion] = "РРРРРРРР",
                [AnimalType.Tiger] = "РАРРРРР",
                [AnimalType.Crocodile] = "РРРРРРЫЫЫЫ",
                [AnimalType.Hippopotamus] = "АРАРАРАРАРА",
                [AnimalType.Lemur] = "ВВММВМКААПА",
                [AnimalType.Monkey] = "УУУУУААААА",
                [AnimalType.Parrot] = "ААААААААА",
                [AnimalType.Zebra] = "ИЭИЭИМИХХАЮИА",
            };
        }
    }
}
