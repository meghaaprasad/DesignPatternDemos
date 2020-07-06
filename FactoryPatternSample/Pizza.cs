using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternSample
{
    public abstract class Pizza
    {
        public abstract void PrintName();
    }

    public class CheesePizza : Pizza
    {
        public override void PrintName()
        {
            Console.WriteLine("Cheese Burst");
        }
    }
    public class DeepDishPizza : Pizza
    {
        public override void PrintName()
        {
            Console.WriteLine("Deep Dish");
        }
    }
}
