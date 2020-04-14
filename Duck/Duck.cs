using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Duck
{
   public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;
        public Duck() { }
        public abstract void Display();
        public void setFlyBehavior(IFlyBehavior fly)
        {
            this.flyBehavior = fly;
        }
        public void setQuackBehavior(IQuackBehavior quack)
        {
            this.quackBehavior = quack;
        }
        public void PerformFly()
        {
            flyBehavior.Fly();
        }
        public void PerformQuack()
        {
            quackBehavior.quack();
        }
        public void Swim()
        {
            Console.WriteLine("All duck float, even decoys!");
        }
    }
}
