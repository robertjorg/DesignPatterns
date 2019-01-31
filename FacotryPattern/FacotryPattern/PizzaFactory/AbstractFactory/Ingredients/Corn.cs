using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacotryPattern.PizzaFactory.FrameworkFactory.Ingredients
{
    class Corn: IVeggies
    {
        public override string ToString()
        {
            return "Corn...are you serious...";
        }
    }
}
