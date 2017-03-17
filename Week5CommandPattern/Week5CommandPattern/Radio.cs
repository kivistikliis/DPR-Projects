using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5CommandPattern
{
    class Radio
    {
        private int volume;
        private bool state;
        private bool cdInside;

        public Radio()
        {
            state = false;
            volume = 0;
            cdInside = false;
        }
        public String increaseVolume()
        {
            if (state == false)
                return "Radio is off! Can't increase volume!";

            volume++;

            if (volume > 20)
                volume = 20;
            return "Volume is: " + volume;
        }
        public String decreaseVolume()
        {
            if (state == false)
                return "Radio is off! Can't decrease volume!";

            volume--;

            if (volume < 0)
                volume = 0;
            return "Volume is: " + volume;
        }
        public String on()
        {
            if (state)
                return "Radio already on!";
            state = true;
            return "Radio is on!";
        }
        public String off()
        {
            state = false;
            return "Radio is off!";
        }
        public String insertCD()
        {
            if (cdInside)
                return "CD already inside!";
            cdInside = true;
            return "CD is inside!";
        }
    }
}
