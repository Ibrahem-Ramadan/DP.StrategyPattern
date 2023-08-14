namespace StrategyPattern.Before.Interface
{
    public abstract class Duck
    {
        public virtual void Swim()
        {
            Console.WriteLine("I'm Swimming");
        }
        public abstract void Display();
    }
}
