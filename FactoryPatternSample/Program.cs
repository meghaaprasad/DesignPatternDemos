using System;

namespace FactoryPatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Pattern");
            PizzaFactory factory = new PizzaFactoryImplementation();
            Pizza pizza=factory.GetFactory("CheeseBurst");
            pizza.PrintName();
            Pizza pizza2 = factory.GetFactory("DeepDish");
            pizza2.PrintName();
            Console.ReadLine();
        }
    }
}
