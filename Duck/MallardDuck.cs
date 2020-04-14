﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Duck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.quackBehavior = new Quack();
            this.flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard Duck!!!");
        }
    }
}
