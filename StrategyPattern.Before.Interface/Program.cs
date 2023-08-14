using StrategyPattern.Before.Interface;

internal class Program
{
    private static void Main(string[] args)
    {
        MallardDuck mallardDuck = new MallardDuck();
        mallardDuck.Display();
        mallardDuck.Fly();
        mallardDuck.Quack();
        Console.WriteLine("------------------------");

        RedheadDuck redheadDuck = new RedheadDuck();
        redheadDuck.Display();
        redheadDuck.Fly();
        redheadDuck.Quack();
        Console.WriteLine("------------------------");

        RubberDuck rubberDuck = new RubberDuck();
        rubberDuck.Display();
        rubberDuck.Quack();
        Console.WriteLine("------------------------");

        DecoyDuck decoyDuck = new DecoyDuck();
        decoyDuck.Display();
    }
}