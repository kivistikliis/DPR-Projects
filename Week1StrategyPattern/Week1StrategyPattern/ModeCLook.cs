using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1StrategyPattern
{
    class ModeCLook: IProcessMode
    {
        public List<int> requests;
        public int currentValue;
        public int minimumOfList;
        public int maximumOfList;

        public ModeCLook(List<int> req, int currentTrbValue)
        {
            requests = req;
            currentValue = currentTrbValue;
            minimumOfList = req.Min();
            maximumOfList = req.Max();
        }
     
        //This method moves heads from nearest end to the bottom, but starts from maximum value of list and ends in minimum value of the list
        public int ProcessList()
        {
            maximumOfList = requests.Max();
            minimumOfList = requests.Min();
                while (currentValue >= minimumOfList)
                {
                    if (requests.Contains(currentValue))
                        return currentValue;
                    currentValue--;
                }
                if (currentValue < minimumOfList)
                {
                    currentValue = maximumOfList;
                    return currentValue;
                }
                return 0;
        }

        public int GetTrackBarValue(int currentTrbValue, int maxTrbValue, int nextNumber, bool TrbDirection)
        {
            if (currentTrbValue < minimumOfList)
            {
                currentTrbValue = maximumOfList;
                return currentTrbValue;
            }
            return --currentTrbValue;
        }
    }
}
