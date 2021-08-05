using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractFactory
{
    public abstract class Pizza
    {
        public string name { get; set; }

        protected Dough _dough;
        protected Sauce _sauce;
        protected List<Veggies> _veggies;
        protected Cheese _cheese;
        protected Pepperoni _pepperoni;
        protected Clams _clams;

        public abstract void prepare();

        public void bake()
        {
            Console.WriteLine("Bake for 25 min at 350");
        }

        public void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public override string ToString()

        {
            StringBuilder result = new StringBuilder();
            result.Append("----" + name + "----\n");
            if(_dough != null)
            {
                result.Append(_dough);
                result.Append("\n");
            }

            return result.ToString();
        }
    }
}
