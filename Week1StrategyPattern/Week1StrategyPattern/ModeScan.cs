using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1StrategyPattern
{
    class ModeScan:IProcessMode
    {
        //List of requests and the current value of the trackbar
        public List<int> requests;
        public int currentValue;
        bool checkdirection;

        public ModeScan(List<int> req, int currentTrbValue, bool dir)
        {
            requests = req;
            currentValue = currentTrbValue;
            checkdirection = dir;
        }
        /*The method will search if there are elements in our list bigger than the trackbar value and take one by 
         * one in their order. If there are no elements bigger than the value of the trackbar, 
         * the method will return the elements lower than the trackbar value one by one in a descending order.
            */
       /* public int ProcessList()
        {
            int max = -1;

            for (int i = 0; i < requests.Count; i++)
                if (requests[i] >= max)
                    max=requests[i];

           if(currentValue<=max)
                while (currentValue <= max)
                {
                    if (requests.Contains(currentValue))
                        return currentValue;
                    currentValue++;
                }
           else
               while (currentValue > -1)
               {
                   if (requests.Contains(currentValue))
                       return currentValue;
                   currentValue--;
               }
           return 0;
        }*/


        public int ProcessList()
        {
            if(checkdirection)
                while (currentValue <= 100)
                {
                    if (requests.Contains(currentValue))
                        return currentValue;
                    currentValue++;
                }
            else
                while (currentValue > -1)
                {
                    if (requests.Contains(currentValue))
                        return currentValue;
                    currentValue--;
                }
            return 0;
        }
    }
}
