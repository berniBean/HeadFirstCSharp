using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class GarageDoor
    {
        private string _garageDoor;
        public GarageDoor(string garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void up()
        {
            Console.WriteLine(_garageDoor + "is Up");
        }

        public void down()
        {
            Console.WriteLine(_garageDoor + "is Down");
        }

        public void lightOn()
        {
            Console.WriteLine(_garageDoor + "is On" );
        }

        public void ligntOff()
        {
            Console.WriteLine(_garageDoor + "is Off");
        }

    }
}
