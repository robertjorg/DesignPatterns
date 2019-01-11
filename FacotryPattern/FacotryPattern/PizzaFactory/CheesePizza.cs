using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.PizzaFactory
{
    class CheesePizza : Pizza
    {
        public override void prepare()
        {
            Console.WriteLine("Prepping a cheese pizza");
        }

        public override void bake()
        {
            Console.WriteLine("Baking a cheese pizza");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting a cheese pizza");
        }

        public override void box()
        {
            Console.WriteLine("Boxing a cheese pizza");
        }
    }
}
