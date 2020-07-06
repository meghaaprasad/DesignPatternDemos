using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPatternSample
{
    public abstract class Pizza
    {
        public abstract void PrintName();
    }

    public  abstract class CheeseBurstPizza : Pizza
    {
        public override void PrintName()
        {
            Console.WriteLine("Cheese Burst");
        }
    }

    public abstract class DeepDishPizza : Pizza
    {
        public override void PrintName()
        {
            Console.WriteLine("Deep Dish");
        }
    }
}
