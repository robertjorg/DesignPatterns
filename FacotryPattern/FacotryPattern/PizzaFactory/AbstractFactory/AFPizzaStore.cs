using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.PizzaFactory.FrameworkFactory;

namespace FactoryPattern.PizzaFactory
{
    public abstract class AFPizzaStore
    {
        public AFPizza orderPizza(String type)
        {
            AFPizza pizza = createPizza(type);

            Console.WriteLine("--- Making a " + pizza.GetName() + " ---");
            pizza.Prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            Console.ReadKey();

            return pizza;
        }

        protected abstract AFPizza createPizza(string paramString);
    }
}
