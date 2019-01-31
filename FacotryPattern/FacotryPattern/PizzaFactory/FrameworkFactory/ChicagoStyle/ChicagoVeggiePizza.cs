using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.PizzaFactory;

namespace FactoryPattern.PizzaFactory.FrameworkFactory.ChicagoStyle
{
    class ChicagoVeggiePizza : FPizza
    {
        public ChicagoVeggiePizza()
        {
            name = "Chicago Style Deep Dish Veggie Pizza";
            dough = "Extra Thick Crust IDough";
            sauce = "Plum Tomato ISauce";
            toppings.Add("Shredded Mozzarella ICheese");
            toppings.Add("Peppers");
            toppings.Add("Other IVeggies you love");
        }

        public void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
