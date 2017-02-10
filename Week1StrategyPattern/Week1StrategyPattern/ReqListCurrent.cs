using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1StrategyPattern
{
    class ReqListCurrent:RequestList
    {
        public ReqListCurrent(IProcessMode mode)
        {
            processmode = mode;
        }
    }
}
