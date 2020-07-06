using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPatternSample
{
    public abstract class PizzaFactory
    {
        public abstract CheeseBurstPizza CreateCheeseBurstPizza();
        public abstract DeepDishPizza CreateDeepDishPizza();
    }

    public class Dominos : PizzaFactory
    {
        public override CheeseBurstPizza CreateCheeseBurstPizza()
        {
            throw new NotImplementedException();
        }

        public override DeepDishPizza CreateDeepDishPizza()
        {
            throw new NotImplementedException();
        }
    }

    public class PizzaHut : PizzaFactory
    {
        public override CheeseBurstPizza CreateCheeseBurstPizza()
        {
            throw new NotImplementedException();
        }

        public override DeepDishPizza CreateDeepDishPizza()
        {
            throw new NotImplementedException();
        }
    }
}
