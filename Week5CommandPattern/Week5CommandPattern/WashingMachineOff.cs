using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5CommandPattern
{
    class WashingMachineOff:Command
    {
        WashingMachine myWM;
        public WashingMachineOff(WashingMachine wm)
        {
            this.myWM = wm;
        }
        public String execute()
        {
            return myWM.off();
        }
    }
}
