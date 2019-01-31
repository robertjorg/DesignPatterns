using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacotryPattern.PizzaFactory.FrameworkFactory.Ingredients;

namespace FacotryPattern.PizzaFactory.FrameworkFactory
{
    public interface PizzaIngredientFactory
    {
        IDough CreateDough();

        ISauce CreateSauce();

        ICheese CreateCheese();

        List<IVeggies> CreateVeggies();

        IPepperoni CreatePepperoni();
    }
}
