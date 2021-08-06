using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class GarageDoorLightOff : Command
    {
        private GarageDoor _garageDoor;
        public GarageDoorLightOff(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;

        }
        public void execute()
        {
            _garageDoor.ligntOff();
        }
    }
}
