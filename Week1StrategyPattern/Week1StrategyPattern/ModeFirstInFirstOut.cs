using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1StrategyPattern
{
    public class ModeFirstInFirstOut:IProcessMode
    {


        public int ProcessList(List<int> requests, int currentValue)
        {
            int numberToBeDeleted = requests[0];

            return numberToBeDeleted;
        }

        public int GetTrackBarValue(List<int> requests,int currentTrbValue, int maxTrbValue, int nextNumber, bool TrbDirection)
        {
            if (nextNumber >= currentTrbValue)
            {
                return ++currentTrbValue;
            }
            else
                return --currentTrbValue;
        }
    }
}
