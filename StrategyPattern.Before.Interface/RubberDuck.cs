using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Before.Interface
{
    public class RubberDuck : Duck, IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Squeak! Squeak!");
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Rubber duck.");
        }
    }
}
