using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    public interface PizzaIngredentFactory
    {
        public Dough createDough();
        public Sauce createSauce();
        public Cheese createCheese();
        public List<Veggies> createVeggies();
        public Pepperoni createPepperoni();
        public Clams createClam();
    }
}
