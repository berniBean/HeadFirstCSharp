using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class StereoOff : Command
    {
        private Stereo _stereo;
        public StereoOff(Stereo stereo)
        {
            _stereo = stereo;
        }
        public void execute()
        {
            _stereo.Off();
        }
    }
}
