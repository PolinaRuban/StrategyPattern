using System;
using StrategyPattern.Ducks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MallarDuck mallarDuck = new MallarDuck();
            mallarDuck.Display();
            mallarDuck.PerformFly();
            mallarDuck.PerformQuack();
            mallarDuck.Swim();
            Console.Read();
        }
    }
}
