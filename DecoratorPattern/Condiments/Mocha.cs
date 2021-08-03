using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    public class Mocha : CondimentDecorator
    {
        Beverage _beverage;
        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override double cost()
        {
            return _beverage.cost() + .20;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + " Mocha";
        }
    }
}
