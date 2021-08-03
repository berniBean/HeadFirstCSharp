using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.baseBeverage
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            _description = "Decaf";
        }
        public override double cost()
        {
            return 1.05;
        }
    }
}
