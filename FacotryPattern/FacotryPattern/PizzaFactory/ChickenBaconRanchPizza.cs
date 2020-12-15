using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.PizzaFactory
{
    class ChickenBaconRanchPizza : Pizza
    {
        public override void prepare()
        {
            Console.WriteLine("Prepping a chicken bacon ranch pizza");
        }

        public override void bake()
        {
            Console.WriteLine("Baking a chicken bacon ranch pizza");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting a chicken bacon ranch pizza");
        }

        public override void box()
        {
            Console.WriteLine("Boxing a chicken bacon ranch pizza");
        }
    }
}
