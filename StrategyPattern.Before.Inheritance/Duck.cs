using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Before.Inheritance
{
    public abstract class Duck
    {
        virtual public void Swim()
        {
            Console.WriteLine("I'm swimming");
        }
        virtual public void Quack()
        {
            Console.WriteLine("Quack! Quack!");
        }
        virtual public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
        abstract public void Display();
    }
}
