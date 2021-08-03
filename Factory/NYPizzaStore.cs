using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string tipo)
        {
            if (tipo.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else if (tipo.Equals("veggie"))
            {
                return new NYStyleVeggiePizza();
            }
            else if (tipo.Equals("clam"))
            {
                return new NYStyleClamPizza();
            }
            else if (tipo.Equals("pepperoni"))
            {
                return new NYStylePepperoniPizza();
            }
            else return null;
        }
    }
}
