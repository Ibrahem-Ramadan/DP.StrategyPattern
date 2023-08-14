namespace StrategyPattern.After
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            _QuackBehavior = new ReallyQuack();

            _FlyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Redhead duck.");
        }
    }
}
