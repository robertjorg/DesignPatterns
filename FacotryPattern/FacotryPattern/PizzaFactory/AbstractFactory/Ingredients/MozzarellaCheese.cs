using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacotryPattern.PizzaFactory.FrameworkFactory.Ingredients
{
    class MozzarellaCheese: ICheese
    {
        public override string ToString()
        {
            return "Mozzarella CheesePizza";
        }
    }
}
