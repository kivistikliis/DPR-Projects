using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1StrategyPattern
{
    class Scan
    {
        public List<int> requests;
        public Scan(List<int> req)
        {
            requests = new List<int>();
            requests = req;
        }
        public List<int> ProcessList()
        {
            return requests;
        }
    }
}
