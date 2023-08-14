using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.After
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            _QuackBehavior = new Squeak();

            _FlyBehavior = new FlyNoWay();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Rubber duck.");
        }
    }
}
