using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
		public ChicagoStylePepperoniPizza()
		{
			name = "Chicago Style Pepperoni Pizza";
			dough = "Extra Thick Crust Dough";
			sauce = "Plum Tomato Sauce";

			toppings.Add("Shredded Mozzarella Cheese");
			toppings.Add("Black Olives");
			toppings.Add("Spinach");
			toppings.Add("Eggplant");
			toppings.Add("Sliced Pepperoni");
		}

		public override void cut()
		{
            Console.WriteLine("Cutting the pizza into square slices");
		}
	}
}
