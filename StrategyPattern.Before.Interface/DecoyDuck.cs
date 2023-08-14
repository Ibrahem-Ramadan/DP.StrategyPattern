namespace StrategyPattern.Before.Interface
{
    public class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a Decoy Duck.");
        }
    }
}
