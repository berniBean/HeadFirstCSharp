using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    public class Soy : CondimentDecorator
    {
        Beverage _beverage;
        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override double cost()
        {
            return _beverage.cost() + .15;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + " Soy";
        }
    }
}
