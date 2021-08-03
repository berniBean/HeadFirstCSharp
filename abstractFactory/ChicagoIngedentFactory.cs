using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    public class ChicagoIngedentFactory : PizzaIngredentFactory
    {
        public Cheese createCheese()
        {
            return new MozzarellaCheese();
        }

        public Clams createClam()
        {
            return new FrozenClams();
        }

        public Dough createDough()
        {
            return new ThickCrustDough();
        }

        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce createSauce()
        {
            return new PlumTomatoSauce();
        }

        public List<Veggies> createVeggies()
        {
            List<Veggies> veggies = new List<Veggies>();
            veggies.Add(new BlackOlives());
            veggies.Add(new Spinach());
            veggies.Add(new Eggplant());
            return veggies;
        }
    }
}
