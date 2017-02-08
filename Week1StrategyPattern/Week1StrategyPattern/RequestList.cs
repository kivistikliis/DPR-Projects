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
        public List<int> requests;
        

        public RequestList()
        {   
            
        }

        public virtual void Process()
        {
            processmode.ProcessList();
        }
    }
}
