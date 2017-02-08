using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1StrategyPattern
{
    class ReqListFIFO:RequestList
    {
        public ReqListFIFO(IProcessMode mode)
        {
            processmode = mode;
        }
    }
}
