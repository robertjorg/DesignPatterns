using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.PizzaFactory.FrameworkFactory;

namespace FactoryPattern.PizzaFactory
{
    public abstract class FPizzaStore
    {
        public FPizza orderPizza(String type)
        {
            FPizza pizza;

            pizza = createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            Console.ReadKey();

            return pizza;
        }

        public abstract FPizza createPizza(string type);
    }
}
