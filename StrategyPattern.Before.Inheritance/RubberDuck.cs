using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Before.Inheritance
{
    public class RubberDuck : Duck
    {
        public override void Fly()
        {
            //Do nothing
            Console.WriteLine("Simulate fly behavior to do nothing");
        }
        public override void Quack()
        {
            Console.WriteLine("Squeak! Squeak!");
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Rubber duck.");
        }
    }
}
