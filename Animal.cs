using System;

namespace TheZooSimulation
{
    public abstract class Animal
    {
        private Gender _gender;
        private string _type;
        private string _sound;

        protected Animal(Gender gender, string type, string sound)
        {
            _gender = gender;
            _type = type ?? throw new ArgumentNullException(nameof(type));
            _sound = sound ?? throw new ArgumentNullException(nameof(sound));
        }

        public override string ToString() =>
            $"Type: {_type} || Sound: {_sound} || Gender: {_gender}";
    }
}
