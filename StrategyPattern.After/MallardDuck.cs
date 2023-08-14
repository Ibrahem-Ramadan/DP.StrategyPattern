namespace StrategyPattern.After
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _QuackBehavior = new ReallyQuack();

            _FlyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Mallard duck.");
        }
    }
}
