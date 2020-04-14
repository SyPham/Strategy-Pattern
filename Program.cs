using System;
using StrategyPattern.Duck;
namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Duck.Duck mallard = new MallardDuck();
            //mallard.PerformQuack();
            //mallard.PerformFly();

            Duck.Duck model = new ModelDuck();
            model.PerformFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}
