using System;

namespace TheZooSimulation
{
    public class ConsoleUtils
    {
        public static int GetNumber(string text)
        {
            int number;

            Console.Write(text);

            while (int.TryParse(Console.ReadLine(), out number) == false)
            {
                Console.WriteLine($"\nCan't convert to {nameof(Int32)}. Try again");
                Console.Write(text);
            }

            return number;
        }

        public static bool TryAnswer(string positive = "yes", string negative = "no")
        {
            string userInput = Console.ReadLine();

            while (userInput.ToLower() != positive.ToLower() && userInput.ToLower() != negative.ToLower())
            {
                Console.WriteLine("\nError! Try again!");
                userInput = Console.ReadLine();
            }

            return userInput.ToLower() == positive.ToLower();
        }
    }
}
