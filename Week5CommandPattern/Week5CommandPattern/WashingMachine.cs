using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5CommandPattern
{
    class WashingMachine
    {
        bool state;
        public String on()
        {
            state = true;
            return "Washing machine is on!";
        }
        public String off()
        {
            state = false;
            return "Washing machine is off!";
        }
    }
}
