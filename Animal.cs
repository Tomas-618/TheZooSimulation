namespace TheZooSimulation
{
    public class Animal
    {
        private readonly Animals _dictionary;
        private readonly Gender _gender;

        public Animal(AnimalType type, Gender gender)
        {
            _dictionary = new Animals();
            Type = type;
            _gender = gender;
            Sound = _dictionary.GetSound(type);
        }

        public AnimalType Type { get; }

        public string Sound { get; }

        public override string ToString() =>
            $"Gender: {_gender}";
    }
}
