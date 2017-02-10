using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1StrategyPattern
{
    class ModeCScan: IProcessMode
    {
        //List of requests and trackbar current value
        public List<int> requests;
        public int currentValue;

        public ModeCScan(List<int> req, int currentTrbValue)
        {
            requests = req;
            currentValue = currentTrbValue;
        }

        //This method moves heads from nearest end to the bottom and returns passing integers for further removal
        public int ProcessList()
        {
            while (currentValue >= 0)
                {
                    if (requests.Contains(currentValue))
                        return currentValue;
                    currentValue--;
                }
                if (currentValue == -1)
                {
                    currentValue = 100;
                    return currentValue;
                }
                return 0;
        }

        public int GetTrackBarValue(int currentTrbValue, int maxTrbValue, int nextNumber, bool TrbDirection)
        {
            if (currentTrbValue == -1)
            {
                currentTrbValue = maxTrbValue;
                return currentTrbValue;
            }
            return --currentTrbValue;
        }
    }
}
