namespace StrategyPattern.Before.Interface
{
    public class MallardDuck : Duck, IFly, IQuack
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
        public void Quack()
        {
            Console.WriteLine("Quack! Quack!");
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Mallard duck.");
        }
    }
}
