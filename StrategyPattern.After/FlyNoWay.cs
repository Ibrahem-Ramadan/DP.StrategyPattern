namespace StrategyPattern.After
{
    public class FlyNoWay : IFly
    {
        public void Fly()
        {
            //do nothing
            Console.WriteLine("I can't fly");
        }
    }
}
