using System;

namespace StrategyPattern
{
    public abstract class Duck
    {
        internal IFlyBehavior flyBehavior;
        internal IQuackBehavior quackBehavior;

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void Swim()
        {
            Console.WriteLine("I swim!");
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            this.flyBehavior = fb;
        }
        public void SetQuackBehavior(IQuackBehavior qb)
        {
            this.quackBehavior = qb;
        }

        public abstract void Display();
    }
}
