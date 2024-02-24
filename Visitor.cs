using System;

namespace TheZooSimulation
{
    public class Visitor
    {
        public void ShowZooInfo(Zoo zoo)
        {
            bool isContinue = true;

            while (isContinue)
            {
                Console.WriteLine($"AviariesCount: {zoo.AviariesCount}");
                int aviaryIndex = ConsoleUtils.GetNumber($"{nameof(Aviary)} index: ");

                Console.WriteLine($"\n{zoo.GetAviaryInfo(aviaryIndex - 1)}");

                Console.WriteLine($"Do you want to choose another {nameof(Aviary).ToLower()}");
                isContinue = ConsoleUtils.TryAnswer();
                Console.Clear();
            }

        }
    }
}
