using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5CommandPattern
{
    class MacroAllOnCommand : Command
    {
        Command[] commands;

        public MacroAllOnCommand(Command[] commands)
        {
            this.commands = commands;
        }
        public String execute()
        {
            for (int i = 0; i < commands.Count(); i++)
            {
                commands[i].execute();
            }
            return "All the devices are on!";
        }
        public String undo()
        {
            for (int i = 0; i < commands.Count(); i++)
            {
                commands[i].undo();
            }
            return "All the devices are off!";
        }
    }
}
