namespace StrategyPattern.After
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            _QuackBehavior = new MuteQuack();

            _FlyBehavior = new FlyNoWay();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Decoy Duck.");
        }
    }
}
