using StrategyPattern.Before.Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        Duck mallardDuck= new MallardDuck();
        mallardDuck.Display();
        mallardDuck.Fly();
        mallardDuck.Quack();
        Console.WriteLine("------------------------");

        Duck redheadDuck = new RedheadDuck();
        redheadDuck.Display();
        redheadDuck.Fly();
        redheadDuck.Quack();
        Console.WriteLine("------------------------");

        Duck rubberDuck = new RubberDuck();
        rubberDuck.Display();
        rubberDuck.Fly();
        rubberDuck.Quack();
    }
}