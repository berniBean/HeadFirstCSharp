using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        protected string _description="Bebida Generica";

        public virtual string GetDescription()
        {
            return _description;
        }

        public abstract double cost();
    }
}
