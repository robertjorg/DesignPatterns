using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacotryPattern.PizzaFactory.ActualFactory.Pizzas;
using FacotryPattern.PizzaFactory.FrameworkFactory;
using FacotryPattern.PizzaFactory.FrameworkFactory.NYStyle;
using FactoryPattern.PizzaFactory;
using FactoryPattern.PizzaFactory.FrameworkFactory.NYStyle;

namespace FactoryPattern.PizzaFactory.FrameworkFactory
{
    class AFNYStylePizzaStore : AFPizzaStore
    {
        private AFPizza pizza = null;
        private PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

        protected override AFPizza createPizza(String item)
        {
            if (item.Equals("cheese"))
            {
                pizza = new FacotryPattern.PizzaFactory.ActualFactory.Pizzas.CheesePizza(ingredientFactory);
                pizza.SetName("New York Style Cheese Pizza");
            }
            else if (item.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("New York Style Veggie Pizza");
            }
            else if (item.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.SetName("New York Style Pepperoni pizza");
            }

            return pizza;
        }
    }
}
