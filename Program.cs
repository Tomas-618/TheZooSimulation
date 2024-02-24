namespace TheZooSimulation
{
    internal class Program
    {
        private static void Main()
        {
            Zoo zoo = new Zoo();

            Visitor visitor = new Visitor();

            visitor.ShowZooInfo(zoo);
        }
    }
}
