using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Stereo
    {
        private string _stereo;

        public Stereo(string stereo)
        {
            _stereo = stereo;
        }

        public void On()
        {
            Console.WriteLine(_stereo + " Stereo is on");
        }

        public void Off()
        {
            Console.WriteLine(_stereo + " Stereo is Off");
        }

        public void setCD()
        {
            Console.WriteLine(_stereo + " Stereo is set for CD Input");
        }
        public void SetDvd()
        {
            Console.WriteLine(_stereo + " Stereo is set for Dvd ");
        }

        public void SetVolume(int volume)
        {

            Console.WriteLine(_stereo + " Stereo volume set to " + volume) ;
        }
    }
}
