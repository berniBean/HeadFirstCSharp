using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CellingFan
    {
        private string _Fan;
        public int lvl { get; set; }
        public static int HIGH = 3;
        public static int MEDIUM = 2;
        public static int LOW = 1;
        public static int OFF = 0;
        public CellingFan(string Fan)
        {
            _Fan = Fan;
        }

        public void high()
        {
            lvl = HIGH;
            Console.WriteLine(_Fan + " Ceilling fan is on High");
        }

        public void medium()
        {
            lvl = MEDIUM;
            Console.WriteLine(_Fan + " Ceilling fan is on Medium");
        }

        public void low()
        {
            lvl = LOW;
            Console.WriteLine(_Fan + " Ceilling fan is on Low");
        }

        public void off()
        {
            lvl = OFF;
            Console.WriteLine(_Fan + " Ceilling fan is off");
        }

        

    }
}
