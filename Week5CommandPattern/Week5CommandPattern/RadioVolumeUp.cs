using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5CommandPattern
{
    class RadioVolumeUp:Command
    {
        Radio myRadio;
        public RadioVolumeUp(Radio r)
        {
            myRadio = r;
        }
        public String execute()
        {
            return myRadio.increaseVolume();
        }
    }
}
