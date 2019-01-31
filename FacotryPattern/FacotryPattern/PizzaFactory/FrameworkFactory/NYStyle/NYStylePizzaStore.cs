using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacotryPattern.PizzaFactory.FrameworkFactory.NYStyle;
using FactoryPattern.PizzaFactory;
using FactoryPattern.PizzaFactory.FrameworkFactory.NYStyle;

namespace FactoryPattern.PizzaFactory.FrameworkFactory
{
    class NYStylePizzaStore : FPizzaStore
    {
        private FPizza pizza = null;

        public override FPizza createPizza(string type)
        {
            if(type.Equals("cheese"))
            {
                pizza = new NYCheesePizza();
            }

            if (type.Equals("veggie"))
            {
                return new NYVeggiePizza();
            }

            return pizza;
        }
    }
}
