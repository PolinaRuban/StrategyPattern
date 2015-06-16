using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.QuackBehavior
{
    public class QuackSound : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack! I'm an ordinary duck");
        }
    }
}
