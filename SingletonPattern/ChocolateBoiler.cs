using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class ChocolateBoiler
    {
        private Boolean _empty;
        private Boolean _boiled;
        private static ChocolateBoiler _uniqueBoiler;

        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        public static ChocolateBoiler GetChocolateBoiler()
        {
            if (_uniqueBoiler == null)
                _uniqueBoiler = new ChocolateBoiler();

            return _uniqueBoiler;
        }

        public void fill()
        {
            if (isEmpty())
            {
                _empty = false;
                _boiled = false;
            }
            Console.WriteLine("Se está llenando" + " " + _uniqueBoiler.GetHashCode());
        }

        public void drain()
        {
            if (!isEmpty() && isBoiled())
                _empty = true;
            Console.WriteLine("Se ha vaciado");
        }

        public void boild()
        {
            if (!isEmpty() && isBoiled())
                _boiled = true;
            Console.WriteLine("Esta hirviendo");
        }

        public Boolean isEmpty()
        {
            return _empty;
        }

        public Boolean isBoiled()
        {
            return _boiled;
        }
    }
}
