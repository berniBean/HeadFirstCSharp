using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    public class NYPizzaStore : PizzaStore
    {
        
        protected override Pizza createPizza(string tipo)
        {
            Pizza pizza = null;
            PizzaIngredentFactory _pizzaIngredentFactory = new NYPizzaIngredientFactory();

            if(tipo.Equals("cheese"))
            {
                pizza = new CheesePizza(_pizzaIngredentFactory);
                pizza.name = "New York Style Cheese pizza";
                pizza.ToString();
            }
            else if (tipo.Equals("veggie"))
            {
                pizza = new VeggiePizza(_pizzaIngredentFactory);
                pizza.name = "New York Style Veggie pizza";
            }
            else if (tipo.Equals("clam"))
            {
                pizza = new ClamPizza(_pizzaIngredentFactory);
                pizza.name = "New York Style Clam pizza";
            }
            else if (tipo.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(_pizzaIngredentFactory);
                pizza.name = "New York Pepperoni Clam pizza";
            }
            return pizza;
        }
    }
}
