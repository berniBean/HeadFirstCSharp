using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string tipo)
        {
            if (tipo.Equals("chesse"))
            {
                return new ChicagoStyleCheesePizza();
            } else if (tipo.Equals("veggie"))
            {
                return new ChicagoStyleVeggiePizza();
            } else if (tipo.Equals("clam"))
            {
                return new ChicagoStyleClamPizza();
            } else if (tipo.Equals("pepperoni")){
                return new ChicagoStylePepperoniPizza();
            } else return null;
        }
    }
}
