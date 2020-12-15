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
            AFPizzaStore afNYPizzaStore = new AFNYStylePizzaStore();
            AFPizzaStore chicagoPizzaStore = new AFChicagoStylePizzaStore();

            AFPizza pizza = afNYPizzaStore.orderPizza("cheese");

            Console.Write(pizza.GetName() + "\n");

            pizza = chicagoPizzaStore.orderPizza("cheese");

            Console.Write(pizza.GetName() + "\n");

            pizza = chicagoPizzaStore.orderPizza("veggie");

            Console.Write(pizza.GetName() + "\n");

            pizza = afNYPizzaStore.orderPizza("veggie");

            Console.WriteLine(pizza.GetName() + "\n");

            pizza = chicagoPizzaStore.orderPizza("pepperoni");

            Console.Write(pizza.GetName() + "\n");

            pizza = afNYPizzaStore.orderPizza("pepperoni");

            Console.WriteLine(pizza.GetName() + "\n");

            //Console.WriteLine("Simple Factory");

            //pizzaStore.orderPizza("cheese");

            //Console.WriteLine("\n");

            //Console.WriteLine("Framework with New York Style ICheese Pizza");

            //FPizza pizza =  fNYPizzaStore.orderPizza("cheese");

            //Console.WriteLine("You ordered a " + pizza.GetName() + "\n");

            //Console.WriteLine("Framework with New York Style Veggie Pizza");

            //pizza = fNYPizzaStore.orderPizza("veggie");

            //Console.WriteLine("You ordered a " + pizza.GetName() + "\n");

            //Console.WriteLine("Framework with Chicago Style ICheese Pizza");

            //pizza = fChicagoStore.orderPizza("cheese");

            //Console.WriteLine("You ordered a " + pizza.GetName() + "\n");

            //Console.WriteLine("Framework with Chicago Style Veggie Pizza");

            //pizza = fChicagoStore.orderPizza("veggie");

            //Console.WriteLine("You ordered a " + pizza.GetName() + "\n");

            Console.ReadKey();
        }
    }
}
