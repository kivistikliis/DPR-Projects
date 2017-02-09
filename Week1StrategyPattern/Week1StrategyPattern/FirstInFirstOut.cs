using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1StrategyPattern
{
    class FirstInFirstOut:IProcessMode
    {
        public List<int> requests;
        public FirstInFirstOut(List<int> req)
        {
            requests = new List<int>();
            requests = req;
        }
        public int ProcessList()
        {
            int numberToBeDeleted = requests[0];
            return numberToBeDeleted;
        }
    }
}
