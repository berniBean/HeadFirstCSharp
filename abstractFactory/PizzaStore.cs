using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    public abstract class PizzaStore
    {
        public Pizza orderPizza(string tipo)
        {
            Pizza pizza = createPizza(tipo);
            Console.WriteLine("---Making a " + pizza.name + "---");
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            return pizza;
        }
        protected abstract Pizza createPizza(string tipo);
    }
}
