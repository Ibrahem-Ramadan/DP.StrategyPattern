namespace StrategyPattern.After
{
    public abstract class Duck
    {
        protected IFly _FlyBehavior;
        protected IQuack _QuackBehavior { get; set; }

        public void PerformFly()
        {
            _FlyBehavior.Fly();
        }
        public void PerformQuack()
        {
            _QuackBehavior.Quack();
        }
        public virtual void Swim()
        {
            Console.WriteLine("I'm Swimming");
        }
        public abstract void Display();
    }
}
