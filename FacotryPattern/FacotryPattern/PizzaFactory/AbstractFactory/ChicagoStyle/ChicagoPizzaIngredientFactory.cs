using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacotryPattern.PizzaFactory.FrameworkFactory.Ingredients;

namespace FacotryPattern.PizzaFactory.FrameworkFactory.ChicagoStyle
{
    class ChicagoPizzaIngredientFactory: PizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new DeepDishDough();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public List<IVeggies> CreateVeggies()
        {
            List<IVeggies> veggies = new List<IVeggies>
            {
                new Onion(),
                new Mushroom(),
                new RedPepper(),
                new Corn(),
            };
            return veggies;
        }

        public IPepperoni CreatePepperoni()
        {
            return new ThickPepperoni();
        }
    }
}
