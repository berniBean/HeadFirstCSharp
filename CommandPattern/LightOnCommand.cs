﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class LightOnCommand : Command
    {
        private Light _light;
        public LightOnCommand(Light light)
        {
            _light = light;
        }
        public void execute()
        {
            _light.on();
        }

        public void undo()
        {
            _light.off();
        }
    }
}
