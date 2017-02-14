using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1StrategyPattern
{
    public class ModeCLook: IProcessMode
    {
        public int ProcessList(List<int> requests, int currentValue)
        {
                while (currentValue >= requests.Min())
                {
                    if (requests.Contains(currentValue))
                        return currentValue;
                    currentValue--;
                }
                if (currentValue < requests.Min())
                {
                    currentValue = requests.Max();
                    return currentValue;
                }
                return 0;
        }
        public int GetTrackBarValue(List<int> requests,int currentTrbValue, int maxTrbValue, int nextNumber, bool TrbDirection)
        {
            if (currentTrbValue < requests.Min())
            {
                currentTrbValue = requests.Max();
                return currentTrbValue;
            }
            return --currentTrbValue;
        }
    }
}
