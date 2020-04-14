using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Duck
{
    public class Quack : IQuackBehavior
    {
       public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
