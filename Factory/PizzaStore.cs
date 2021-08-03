using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class PizzaStore
    {
        public Pizza orderPizza(string tipo)
        {
            Pizza pizza;
            pizza = createPizza(tipo);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            return pizza;
        }
        protected abstract Pizza createPizza(string tipo);
    }
}
