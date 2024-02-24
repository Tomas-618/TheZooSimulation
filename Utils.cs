using System;

namespace TheZooSimulation
{
    public class Utils
    {
        private static readonly Random _random;

        static Utils() =>
            _random = new Random();

        public static int GetRandomNumber(in int minValue, in int maxValue) =>
            _random.Next(minValue, maxValue + 1);

        public static int GetRandomNumber(in int maxValue) =>
            _random.Next(maxValue + 1);
    }
}
