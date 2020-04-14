using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Duck
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            this.quackBehavior = new Quack();
            this.flyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a real Model Duck!!!");

        }
    }
}
