using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacotryPattern.PizzaFactory.FrameworkFactory;
using FactoryPattern.PizzaFactory;

namespace FacotryPattern.PizzaFactory.ActualFactory.Pizzas
{
    class PepperoniPizza : AFPizza
    {
        private PizzaIngredientFactory ingredientFactory;

        public PepperoniPizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = ingredientFactory.CreateDough();
            Console.WriteLine(dough.ToString());
            sauce = ingredientFactory.CreateSauce();
            Console.WriteLine(sauce.ToString());
            cheese = ingredientFactory.CreateCheese();
            Console.WriteLine(cheese.ToString());
            pepperoni = ingredientFactory.CreatePepperoni();
            Console.WriteLine(pepperoni.ToString());
        }
    }
}
