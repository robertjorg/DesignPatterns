using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.PizzaFactory.FrameworkFactory;
using FactoryPattern.PizzaFactory;
using FactoryPattern.PizzaFactory.FrameworkFactory.ChicagoStyle;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SimplePizzaFactory simpleFactory = new SimplePizzaFactory();
            PizzaStore pizzaStore = new PizzaStore(simpleFactory);
            FPizzaStore fNYPizzaStore = new NYStylePizzaStore();
            FPizzaStore fChicagoStore = new ChicagoStylePizzaStore();

            Console.WriteLine("Simple Factory");

            pizzaStore.orderPizza("cheese");

            Console.ReadKey();

            Console.WriteLine("Framework with New York Style Pizza");

            fNYPizzaStore.orderPizza("cheese");

            Console.ReadKey();

            Console.WriteLine("Framework with Chicago Style Pizza");

            fChicagoStore.orderPizza("cheese");

            Console.ReadKey();
        }
    }
}
