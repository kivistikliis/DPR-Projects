using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5CommandPattern
{
    class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;
        List<Command> undoCommand;

        public RemoteControl() {
            onCommands = new Command[4];
            offCommands = new Command[4];
            undoCommand = new List<Command>();
            Command noCommand = new NoCommand();
            
            
            for (int i = 0; i < 3; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }
        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }
        public String onButtonWasPushed(int slot)
        {
            undoCommand.Add(onCommands[slot]);
            return onCommands[slot].execute();
        }
        public String offButtonWasPushed(int slot)
        {
            undoCommand.Add(offCommands[slot]);
            return offCommands[slot].execute();
        }
        public String undoButtonWasPushed()
        {
            try
            {
                string message = undoCommand[undoCommand.Count - 1].undo();
                undoCommand.RemoveAt(undoCommand.Count - 1);
                return message;
            }
            catch (ArgumentOutOfRangeException)
            {
                return "No command was fired yet!";
            }
        }
    }
}
