using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.PizzaFactory;

namespace FactoryPattern.PizzaFactory.FrameworkFactory.NYStyle
{
    class NYCheesePizza : FPizza
    {
        public override void prepare()
        {
            Console.WriteLine("New York thin crust being prepared");
        }

        public override void bake()
        {
            Console.WriteLine("New York thin crust being baked");
        }

        public override void cut()
        {
            Console.WriteLine("New York thin crust being cut");
        }

        public override void box()
        {
            Console.WriteLine("New York thin crust being boxed");
        }
    }
}
