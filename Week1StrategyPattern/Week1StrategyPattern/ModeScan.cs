using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1StrategyPattern
{
    public class ModeScan:IProcessMode
    {
        public bool checkdirection;

        //This method moves trackbar up and down and returns integers in the order of passing them (ascending or descending)
        public int ProcessList(List<int> requests, int currentValue)
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

        public int GetTrackBarValue(List<int> requests, int currentTrbValue, int maxTrbValue, int nextNumber, bool TrbDirection)
        {
            if (TrbDirection)
            {
                return ++currentTrbValue;
            }
            else return --currentTrbValue;
        }
    }
}
