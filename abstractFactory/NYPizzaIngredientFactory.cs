using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    public class NYPizzaIngredientFactory : PizzaIngredentFactory
    {
        public Cheese createCheese()
        {
            var Chees = new ReggianoCheese();
            Console.WriteLine(Chees.ToString());
            return Chees;
        }

        public Clams createClam()
        {
            var Clams =  new FreshClams();
            Console.WriteLine(Clams.ToString());
            return Clams;
        }

        public Dough createDough()
        {
            var doug = new ThinCrustDough();
            Console.WriteLine(doug.ToString()); 
            return doug;
        }

        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce createSauce()
        {
            var Sauce = new MarinaraSauce();
            Console.WriteLine(Sauce.ToString()); 
            return Sauce;
        }

        public List<Veggies> createVeggies()
        {
            List<Veggies> veggies = new List<Veggies>();
            veggies.Add(new Garlic());
            veggies.Add(new Onion());
            veggies.Add(new Mushroom());
            veggies.Add(new RedPepper());

            return veggies;
        }
    }
}
