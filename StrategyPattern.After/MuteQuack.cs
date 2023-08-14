namespace StrategyPattern.After
{
    public class MuteQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("I can't quack!");
        }
    }
}
