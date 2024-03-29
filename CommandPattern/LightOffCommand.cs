﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    //concquete command
    public class LightOffCommand : Command
    {
        Light _light;
        
        public LightOffCommand(Light light)
        {
            _light = light;
        }
        
        public void execute()
        {
            _light.off();
        }

        public void undo()
        {
            _light.on();
        }
    }
}
