using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.PizzaFactory
{
    public abstract class FPizza
    {
        public abstract void prepare();

        public abstract void bake();

        public abstract void cut();

        public abstract void box();
    }
}
