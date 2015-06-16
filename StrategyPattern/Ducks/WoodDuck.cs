using System;
using StrategyPattern.FlyBehavior;
using StrategyPattern.QuackBehavior;

namespace StrategyPattern.Ducks
{
    class WoodDuck : Duck
    {
        public WoodDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteDuck();
        }

        public override void Display()
        {
            Console.WriteLine("I'm wood duck");
        }
    }
}
