using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.PizzaFactory;

namespace FactoryPattern.PizzaFactory.FrameworkFactory.ChicagoStyle
{
    class ChicagoCheesePizza : FPizza
    {
        public override void prepare()
        {
            Console.WriteLine("Chicago deep dish being prepared");
        }

        public override void bake()
        {
            Console.WriteLine("Chicago deep dish being baked");
        }

        public override void cut()
        {
            Console.WriteLine("Chicago deep dish being cut");
        }

        public override void box()
        {
            Console.WriteLine("Chicago deep dish being boxed");
        }
    }
}
