using System;
using StrategyPattern.FlyBehavior;
using StrategyPattern.QuackBehavior;

namespace StrategyPattern.Ducks
{
    public class MallarDuck : Duck
    {
        public MallarDuck()
        {
            quackBehavior = new QuackSound();
            flyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("Yup, I'm just mallar duck");
        }
    }
}
