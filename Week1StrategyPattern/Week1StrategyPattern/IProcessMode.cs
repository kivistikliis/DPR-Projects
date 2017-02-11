using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1StrategyPattern
{
    interface IProcessMode
    {

        int ProcessList(); // returns int that will be removed from the list
        int GetTrackBarValue(int currentTrbValue, int maxTrbValue, int nextNumber, bool TrbDirection); //gets new trackbar value, which sets trackbar direction
       
    }
}
