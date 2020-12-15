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
        private readonly PizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();
        private AFPizza pizza = null;

        protected override AFPizza createPizza(String item)
        {
            if (item.Equals("cheese"))
            {
                this.pizza = new FacotryPattern.PizzaFactory.ActualFactory.Pizzas.CheesePizza(ingredientFactory);
                this.pizza.SetName("Chicago Style Cheese Pizza");
            }
            else if (item.Equals("veggie"))
            {
                this.pizza = new VeggiePizza(ingredientFactory);
                this.pizza.SetName("Chicago Style Veggie Pizza");
            }
            else if (item.Equals("pepperoni"))
            {
                this.pizza = new PepperoniPizza(ingredientFactory);
                this.pizza.SetName("Chicago Style Pepperoni Pizza");
            }

            return this.pizza;
        }
    }
}
