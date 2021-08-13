using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class Tea : CaffeineBeverage
    {
        protected override void addCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        protected override void brew()
        {
            Console.WriteLine("Steeping the tea");
        }
    }
}
