using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacotryPattern.PizzaFactory.ActualFactory.Pizzas;
using FacotryPattern.PizzaFactory.FrameworkFactory;
using FacotryPattern.PizzaFactory.FrameworkFactory.ChicagoStyle;
using FacotryPattern.PizzaFactory.FrameworkFactory.NYStyle;
using FactoryPattern.PizzaFactory;

namespace FactoryPattern.PizzaFactory.FrameworkFactory.ChicagoStyle
{
    class AFChicagoStylePizzaStore : AFPizzaStore
    {
        private AFPizza pizza = null;
        private PizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

        protected override AFPizza createPizza(String item)
        {
            if (item.Equals("cheese"))
            {
                pizza = new FacotryPattern.PizzaFactory.ActualFactory.Pizzas.CheesePizza(ingredientFactory);
                pizza.SetName("Chicago Style Cheese Pizza");
            }
            else if (item.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("Chicago Style Veggie Pizza");
            }

            return pizza;
        }
    }
}
