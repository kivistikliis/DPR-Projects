using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1StrategyPattern
{
    abstract class RequestList
    {
        public IProcessMode processmode;        

        public virtual int Process()
        {
            return processmode.ProcessList();
        }
    }
}
