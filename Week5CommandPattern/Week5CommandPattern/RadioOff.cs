using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5CommandPattern
{
    class RadioOff:Command
    {
        Radio myRadio;
        public RadioOff(Radio r)
        {
            this.myRadio = r;
        }
        public String execute()
        {
            return myRadio.off();
        }
        public String undo()
        {
            return myRadio.on();
        }
    }
}
