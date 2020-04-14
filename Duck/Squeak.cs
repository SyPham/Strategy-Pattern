using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Duck
{
   public class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
