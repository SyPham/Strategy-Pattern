using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Duck
{
    public class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Silence");

        }
    }
}
