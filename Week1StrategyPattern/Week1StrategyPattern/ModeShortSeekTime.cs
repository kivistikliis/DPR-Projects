using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1StrategyPattern
{
    public class ModeShortSeekTime: IProcessMode
    {
        //List of requests and the current value of the trackbar
        public List<int> requests;
        public int currentValue;

        public ModeShortSeekTime(List<int> req, int currentTrbValue)
        {
            requests = req;
            currentValue = currentTrbValue;
        }
        /*The method is going to find the mini difference between the trackbar value and a number in the request list.
        After finding this min and the number from the list, this number will be returned
         */
        public int ProcessList()
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

        public int GetTrackBarValue(int currentTrbValue, int maxTrbValue, int nextNumber, bool TrbDirection)
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
