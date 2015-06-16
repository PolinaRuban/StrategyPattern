using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.QuackBehavior
{
    public class MuteDuck : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I cannot make a sound. Sorry");
        }
    }
}
