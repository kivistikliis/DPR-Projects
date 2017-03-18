using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5CommandPattern
{
    class RadioVolumeDown:Command
    {
        Radio myRadio;
        public RadioVolumeDown(Radio r)
        {
            myRadio = r;
        }
        public String execute()
        {
            return myRadio.decreaseVolume();
        }
        public String undo()
        {
            return myRadio.increaseVolume();
        }
    }
}
