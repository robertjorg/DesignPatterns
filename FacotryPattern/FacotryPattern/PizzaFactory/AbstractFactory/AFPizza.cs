using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using FacotryPattern.PizzaFactory.FrameworkFactory.Ingredients;

namespace FactoryPattern.PizzaFactory
{
    public abstract class AFPizza
    {
        public string name;
        public IDough dough;
        public ISauce sauce;
        public ICheese cheese;
        public IPepperoni pepperoni;
        public List<IVeggies> veggies;


        public abstract void Prepare();

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

        public void SetName(string name)
        {
            this.name = name;
        }

        public String GetName()
        {
            return name;
        }
    }
}
