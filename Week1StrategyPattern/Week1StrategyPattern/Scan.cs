using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1StrategyPattern
{
    class Scan
    {
        //List of requests and the current value of the trackbar
        public List<int> requests;
        public int currentValue;

        public Scan(List<int> req, int currentTrbValue)
        {
            requests = req;
            currentValue = currentTrbValue;
        }
        /*The method will search if there are elements in our list bigger than the trackbar value and take one by 
         * one in their order. If there are no elements bigger than the value of the trackbar, 
         * the method will return the elements lower than the trackbar value one by one in a descending order.
            */
        public int ProcessList()
        {
            int max = -1;

            for (int i = 0; i < requests.Count; i++)
                if (requests[i] > max)
                    max=requests[i];

           if(currentValue<max)
                while (currentValue < max)
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
