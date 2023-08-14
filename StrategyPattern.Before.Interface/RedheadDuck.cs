namespace StrategyPattern.Before.Interface
{
    public class RedheadDuck : Duck, IFly, IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Redhead duck.");
        }
    }
}
