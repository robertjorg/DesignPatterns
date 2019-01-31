using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.PizzaFactory;

namespace FacotryPattern.PizzaFactory.FrameworkFactory.NYStyle
{
    class NYVeggiePizza : FPizza
    {
        public NYVeggiePizza()
        {
            name = "NY Style ISauce and ICheese Pizza";
            dough = "Thin Crust IDough";
            sauce = "Marinara ISauce";
            toppings.Add("Grated Reggiano ICheese");
            toppings.Add("Peppers");
            toppings.Add("Other IVeggies you love");
        }
        
    }
}
