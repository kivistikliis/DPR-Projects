using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5CommandPattern
{
    class WashingMachineOn:Command
    {
        WashingMachine myWM;
        public WashingMachineOn(WashingMachine wm)
        {
            this.myWM = wm;
        }
        public String execute()
        {
            return myWM.on();
        }
    }
}
