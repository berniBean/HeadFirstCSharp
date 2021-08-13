using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class GagareDoorLightOn : Command
    {
        GarageDoor _garageDoor;
        public GagareDoorLightOn(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }
        public void execute()
        {
            _garageDoor.lightOn();
        }

        public void undo()
        {
            _garageDoor.ligntOff();
        }
    }
}
