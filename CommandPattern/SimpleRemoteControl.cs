using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class SimpleRemoteControl
    {
        private Command _slot;
        

        public SimpleRemoteControl()
        {

        }

        public void setCommand(Command command)
        {
            _slot = command;
            
        }
        //invoker
        public void buttonWasPressed()
        {

            _slot.execute();
        }
        
    }
}
