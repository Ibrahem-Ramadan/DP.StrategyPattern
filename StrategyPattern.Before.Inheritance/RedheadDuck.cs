namespace StrategyPattern.Before.Inheritance
{
    public class RedheadDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Quack!");
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Redhead duck.");
        }
    }
}
