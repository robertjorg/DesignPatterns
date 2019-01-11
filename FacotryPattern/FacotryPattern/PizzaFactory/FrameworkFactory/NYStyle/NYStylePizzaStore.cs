using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            return pizza;
        }
    }
}
