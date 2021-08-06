using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CellingFanOnHigh : Command
    {
        private CellingFan _cellingFan;

        public CellingFanOnHigh(CellingFan cellingFan)
        {
            _cellingFan = cellingFan;
        }
        public void execute()
        {
            _cellingFan.high();
        }
    }
}
