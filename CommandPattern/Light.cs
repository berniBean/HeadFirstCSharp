using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    //Reciver
    public class Light
    {
        private string _LightName; 
        public Light( string name )
        {
            _LightName = name;
        }

        public void on()
        {
            Console.WriteLine(_LightName + " is on");
        }

        public void off()
        {
            Console.WriteLine(_LightName +  " is off");
        }
    }
}
