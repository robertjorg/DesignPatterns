using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.PizzaFactory
{
    class SimplePizzaFactory
    {
        public Pizza createPizza(String type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }

            return pizza;
        }
    }
}
