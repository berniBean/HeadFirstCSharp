using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class RemoteControl
    {
        private Command[] _onCommands;
        private Command[] _offCommands;

        public RemoteControl()
        {
            _onCommands = new Command[7];
            _offCommands = new Command[7];

            Command noCommand = new NoCommand();
            
            for(int i = 0; i<7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
        }

        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void onButtonWasPuhed(int slot)
        {
            _onCommands[slot].execute();
        }

        public void offButtonWasPushed(int slot)
        {
            _offCommands[slot].execute();
        }

        public override string ToString()
        {
            StringBuilder stringbuff = new StringBuilder();

            stringbuff.Append("\n----- Remote Control ------\n");
            for(int i = 0; i < _onCommands.Length; i++)
            {
                stringbuff.Append($"[slot " + i + "] " + _onCommands[i].GetType().Name + "  " + _offCommands[i].GetType().Name + "\n");
            }
            return stringbuff.ToString();
        }
    }
}
