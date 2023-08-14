namespace StrategyPattern.After
{
    public class ReallyQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Quack! Quack!");
        }
    }
}
