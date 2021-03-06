﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.PizzaFactory
{
    public abstract class FPizza
    {
        public string name;
        public string dough;
        public string sauce;
        public List<string> toppings = new List<string>();

        public void prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough... " + dough);
            Console.WriteLine("Adding " + sauce);
            Console.WriteLine("Adding toppings");
            foreach (var topping in toppings)
            {
                Console.WriteLine(" " + topping);
            }
        }

        public void bake()
        {
            Console.WriteLine("Baking your " + name + " for 25 minutes at 350 degrees F");
        }

        public void cut()
        {
             Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public String GetName()
        {
            return name;
        }
    }
}
