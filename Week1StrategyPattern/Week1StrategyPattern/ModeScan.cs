using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1StrategyPattern
{
    class ModeScan:IProcessMode
    {
        //List of requests,current value of the trackbar, bool that indicates trackbar direction (true goes up, false goes down)
        public List<int> requests;
        public int currentValue;
        public bool checkdirection;

        public ModeScan(List<int> req, int currentTrbValue, bool dir)
        {
            requests = req;
            currentValue = currentTrbValue;
            checkdirection = dir;
        }

        //This method moves trackbar up and down and returns integers in the order of passing them (ascending or descending)
        public int ProcessList()
        {
            int aux=0;
            
            if (checkdirection)
            {
                while (currentValue <= 100)
                {
                    if (requests.Contains(currentValue))
                    {
                        aux = currentValue;
                        break;
                        
                    }
                    currentValue++;
                }
            }
            else
            {
                while (currentValue > -1)
                {
                    if (requests.Contains(currentValue))
                    {
                        aux = currentValue;
                        break;
                        
                    }
                    currentValue--;
                }
            }
            return aux;
        }

        public int GetTrackBarValue(int currentTrbValue, int maxTrbValue, int nextNumber, bool TrbDirection)
        {
            if (TrbDirection)
            {
                return ++currentTrbValue;
            }
            else return --currentTrbValue;
        }
    }
}
