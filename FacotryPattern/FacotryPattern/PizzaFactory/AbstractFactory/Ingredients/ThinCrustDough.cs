using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacotryPattern.PizzaFactory.FrameworkFactory.Ingredients
{
    class ThinCrustDough : IDough
    {
        public override string ToString()
        {
            return "Thin Crust Dough";
        }
    }
}
