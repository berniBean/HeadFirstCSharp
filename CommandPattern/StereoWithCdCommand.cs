using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class StereoWithCdCommand : Command
    {
        private Stereo _stereo;
        public StereoWithCdCommand(Stereo stereo)
        {
            _stereo = stereo;
        }
        public void execute()
        {
            _stereo.On();
            _stereo.setCD();
            _stereo.SetVolume(5);
        }

        public void undo()
        {
            _stereo.Off();
        }
    }
}
