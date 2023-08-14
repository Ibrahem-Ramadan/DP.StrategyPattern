using StrategyPattern.After;

internal class Program
{
    private static void Main(string[] args)
    {
        Duck mallardDuck = new MallardDuck();
        mallardDuck.Display();
        mallardDuck.PerformFly();
        mallardDuck.PerformQuack();
        Console.WriteLine("------------------------");

        RedheadDuck redheadDuck = new RedheadDuck();
        redheadDuck.Display();
        redheadDuck.PerformFly();
        redheadDuck.PerformQuack();
        Console.WriteLine("------------------------");

        RubberDuck rubberDuck = new RubberDuck();
        rubberDuck.Display();
        rubberDuck.PerformFly();
        rubberDuck.PerformQuack();
        Console.WriteLine("------------------------");

        DecoyDuck decoyDuck = new DecoyDuck();
        decoyDuck.Display();
        decoyDuck.PerformFly();
        decoyDuck.PerformQuack();
    }
}