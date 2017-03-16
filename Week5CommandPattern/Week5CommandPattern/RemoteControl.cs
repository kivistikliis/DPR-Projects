using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5CommandPattern
{
    class RemoteControl
    {
        Command firstCommand;

        public RemoteControl() { }

        public void setCommand(Command com)
        {
            firstCommand = com;
        }

        public String buttonPressed()
        {
            return firstCommand.execute();
        }
    }
}
