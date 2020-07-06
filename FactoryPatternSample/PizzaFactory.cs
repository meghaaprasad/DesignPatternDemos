using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternSample
{
    public abstract class PizzaFactory
    {
        public abstract Pizza GetFactory(string name);
    }

    public class PizzaFactoryImplementation : PizzaFactory
    {

        public override Pizza GetFactory(string name)
        {
            if (string.Equals(name, "CheeseBurst"))
            { 
                return new CheesePizza(); 
            }
            else
            {
                return new DeepDishPizza();
            }

        }

    }

}
