using System;
using StrategyPattern.FlyBehavior;
using StrategyPattern.QuackBehavior;

namespace StrategyPattern.Ducks
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            quackBehavior = new QuackSound();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm readhead duck");
        }
    }
}
