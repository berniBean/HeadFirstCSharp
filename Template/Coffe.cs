using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Coffe : CaffeineBeverage
    {
        protected override void addCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        protected override void brew()
        {
            Console.WriteLine("Dripping Coffee through filter");   
        }
    }
}
