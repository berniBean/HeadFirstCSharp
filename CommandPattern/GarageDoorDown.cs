using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class GarageDoorDown : Command
    {
        private GarageDoor _garageDoor;
        public GarageDoorDown(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }
        public void execute()
        {
            _garageDoor.down();
        }

        public void undo()
        {
            _garageDoor.up();
        }
    }
}
