using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CellingFanOff : Command
    {
        private CellingFan _cellingFan;
        public CellingFanOff(CellingFan cellingFan)
        {
            _cellingFan = cellingFan;
        }
        public void execute()
        {
            _cellingFan.off();
        }

        public void undo()
        {
            _cellingFan.high();
        }
    }
}
