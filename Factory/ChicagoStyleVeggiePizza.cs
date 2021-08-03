using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
		public ChicagoStyleVeggiePizza()
		{
			name = "Chicago Deep Dish Veggie Pizza";
			dough = "Extra Thick Crust Dough";
			sauce = "Plum Tomato Sauce";

			toppings.Add("Shredded Mozzarella Cheese");
			toppings.Add("Black Olives");
			toppings.Add("Spinach");
			toppings.Add("Eggplant");
		}

		public override void cut()
		{
            Console.WriteLine("Cutting the pizza into square slices");
		}
	}
}
