using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1StrategyPattern
{
    class ModeFirstInFirstOut:IProcessMode
    {
        //list of requests
        public List<int> requests;
        public ModeFirstInFirstOut(List<int> req)
        {
            requests = new List<int>();
            requests = req;
        }

        //This method returns first integer in the list for further removal
        public int ProcessList()
        {
            int numberToBeDeleted = requests[0];
            return numberToBeDeleted;
        }

        public int GetTrackBarValue(int currentTrbValue, int maxTrbValue, int nextNumber, bool TrbDirection)
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
