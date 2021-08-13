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
        private Command _undoCommands;

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
            _undoCommands = noCommand;
        }

        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void onButtonWasPuhed(int slot)
        {
            _onCommands[slot].execute();
            _undoCommands = _onCommands[slot];
        }

        public void offButtonWasPushed(int slot)
        {
            _offCommands[slot].execute();
            _undoCommands = _offCommands[slot];
        }

        public void undoButtonWasPushed()
        {
            _undoCommands.undo();
        }

        public override string ToString()
        {
            StringBuilder stringbuff = new StringBuilder();

            stringbuff.Append("\n----- Remote Control ------\n");
            for(int i = 0; i < _onCommands.Length; i++)
            {
                stringbuff.Append($"[slot " + i + "] " + _onCommands[i].GetType().Name + "  " + _offCommands[i].GetType().Name + "\n");
            }
            stringbuff.Append("[undo] " + _undoCommands.GetType().Name +"\n ");
            return stringbuff.ToString();
        }

        public void setCommand(int v, Action p1, Action p2)
        {
            throw new NotImplementedException();
        }

        public void setCommand(int v, Action p, LightOffCommand livingOff)
        {
            throw new NotImplementedException();
        }
    }
}
