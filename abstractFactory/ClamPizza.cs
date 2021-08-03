using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    public class ClamPizza : Pizza
    {
        PizzaIngredentFactory _pizzaIngredentFactory;
        public ClamPizza(PizzaIngredentFactory pizzaIngredentFactory)
        {
            _pizzaIngredentFactory = pizzaIngredentFactory;
        }
        public override void prepare()
        {
            Console.WriteLine("Preparing: " + name);
            _dough = _pizzaIngredentFactory.createDough();
            _sauce = _pizzaIngredentFactory.createSauce();
            _cheese = _pizzaIngredentFactory.createCheese();
            _clams = _pizzaIngredentFactory.createClam();
        }
    }
}
