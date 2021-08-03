using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class Pizza
    {
        protected String name { get; set; }
        protected String dough;
        protected String sauce;
        protected List<string> toppings = new List<string>();

        public void prepare()
        {
            Console.WriteLine("Prepare " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach (var item in toppings)
            {
                Console.WriteLine("   " + item);
            }
        }
        public void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void cut()
        {
            Console.WriteLine("Cut the pizza into diagonal slices");
        }

        public void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public override string ToString()
        {
            return "--- " + name + " ---\n" + dough + "\n" + sauce + "\n";
        }
    }
}
