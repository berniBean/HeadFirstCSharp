using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class CaffeineBeverage
    {
        public  void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            addCondiments();
        }

        protected abstract void brew();
        protected abstract void addCondiments();

        protected void boilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

    }
}
