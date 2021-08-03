using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    public class CheesePizza : Pizza
    {
        PizzaIngredentFactory _ingredentFactory;

        public CheesePizza(PizzaIngredentFactory ingredentFactory)
        {
            _ingredentFactory = ingredentFactory;
        }
        public override void prepare()
        {
            Console.WriteLine("Preparing: " + name);
            _dough = _ingredentFactory.createDough();
            _sauce = _ingredentFactory.createSauce();
            _cheese = _ingredentFactory.createCheese();
        }
    }
}
