using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacotryPattern.PizzaFactory.FrameworkFactory.Ingredients;

namespace FacotryPattern.PizzaFactory.FrameworkFactory.NYStyle
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public List<IVeggies> CreateVeggies()
        {
            List<IVeggies> veggies = new List<IVeggies>
            {
                new Garlic(),
                new Onion(),
                new Mushroom(),
                new RedPepper()
            };
            return veggies;
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }
    }
}
