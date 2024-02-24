using System.Collections.Generic;

namespace TheZooSimulation
{
    public class Zoo
    {
        private List<Aviary> _aviaries;
        private Animals _dictionary;

        public Zoo()
        {
            _dictionary = new Animals();
            _aviaries = FillAviaries();
        }

        public int AviariesCount => _aviaries.Count;

        public string GetAviaryInfo(in int aviaryIndex) =>
            _aviaries.IsContainsKey(aviaryIndex) ? _aviaries[aviaryIndex].ToString() : "Can't find this aviary";

        private List<Aviary> FillAviaries()
        {
            List<Aviary> aviaries = new List<Aviary>();

            int minAviariesCount = 4;
            int maxAviariesCount = 8;

            int aviariesCount = Utils.GetRandomNumber(minAviariesCount, maxAviariesCount);

            for (int i = 0; i < aviariesCount; i++)
            {
                aviaries.Add(new Aviary(_dictionary.GetRandomType()));
            }

            return aviaries;
        }
    }
}
