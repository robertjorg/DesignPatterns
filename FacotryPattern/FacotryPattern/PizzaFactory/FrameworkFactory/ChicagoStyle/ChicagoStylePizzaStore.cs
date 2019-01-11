using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.PizzaFactory;

namespace FactoryPattern.PizzaFactory.FrameworkFactory.ChicagoStyle
{
    class ChicagoStylePizzaStore : FPizzaStore
    {
        private FPizza pizza = null;

        public override FPizza createPizza(string type)
        {
            if (type.Equals("cheese"))
            {
                pizza = new ChicagoCheesePizza();
            }

            return pizza;
        }
    }
}
