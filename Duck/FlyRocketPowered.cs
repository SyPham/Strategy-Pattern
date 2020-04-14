using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Duck
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I fly with rocket!!!");

        }
    }
}
