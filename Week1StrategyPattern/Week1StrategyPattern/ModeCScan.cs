using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1StrategyPattern
{
    public class ModeCScan: IProcessMode
    {


        //This method moves heads from nearest end to the bottom and returns passing integers for further removal
        public int ProcessList(List<int> requests, int currentValue)
        {
            while (currentValue >= 0)
                {
                    if (requests.Contains(currentValue))
                        return currentValue;
                    currentValue--;
                }
                if (currentValue == -1)
                {
                    currentValue = requests.Max();
                    return currentValue;
                }
                return 0;
        }

        public int GetTrackBarValue(List<int> requests,int currentTrbValue, int maxTrbValue, int nextNumber, bool TrbDirection)
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
