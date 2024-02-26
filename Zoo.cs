using System.Collections.Generic;

namespace TheZooSimulation
{
    public class Zoo
    {
        private List<Aviary> _aviaries;
        private Container _container;

        public Zoo()
        {
            _container = new Container();
            _aviaries = _container.CreateAviaries();
        }

        public int AviariesCount => _aviaries.Count;

        public string GetAviaryInfo(in int aviaryIndex) =>
            _aviaries.IsContainsKey(aviaryIndex) ? _aviaries[aviaryIndex].ToString() : "Can't find this aviary";
    }
}
