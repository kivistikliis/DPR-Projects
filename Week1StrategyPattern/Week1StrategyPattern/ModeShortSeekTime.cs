using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1StrategyPattern
{
    public class ModeShortSeekTime: IProcessMode
    {
        /*The method is going to find the mini difference between the trackbar value and a number in the request list.
        After finding this min and the number from the list, this number will be returned
         */
        public int ProcessList(List<int> requests, int currentValue)
        {
            int min = 32000;
            int numberToBeDeleted=0;

            for (int i = 0; i < requests.Count; i++)
                if (Math.Abs(currentValue - requests[i]) < min)
                {
                    min = Math.Abs(currentValue - requests[i]);
                    numberToBeDeleted=requests[i];

                    
                }
            if (numberToBeDeleted >= currentValue) currentValue++;
            else currentValue--;

            return numberToBeDeleted;
        }

        public int GetTrackBarValue(List<int> requests, int currentTrbValue, int maxTrbValue, int nextNumber, bool TrbDirection)
        {
            if (nextNumber > currentTrbValue)
            {
               return ++currentTrbValue;
            }
            else
               return --currentTrbValue;
        }
    }
}
