using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1StrategyPattern
{
    public abstract class RequestList
    {
        public IProcessMode processmode;        

        //This method processes one request, returns int as the number to be removed
        public virtual int Process()
        {
            return processmode.ProcessList();
        }

        
    }
}
