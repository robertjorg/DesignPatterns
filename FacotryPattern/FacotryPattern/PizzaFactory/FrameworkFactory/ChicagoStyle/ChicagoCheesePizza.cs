﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.PizzaFactory;

namespace FactoryPattern.PizzaFactory.FrameworkFactory.ChicagoStyle
{
    class ChicagoCheesePizza : FPizza
    {
        public ChicagoCheesePizza()
        {
            name = "Chicago Style Deep Dish ICheese Pizza";
            dough = "Extra Thick Crust IDough";
            sauce = "Plum Tomato ISauce";
            toppings.Add("Shredded Mozzarella ICheese");
        }

        public void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
