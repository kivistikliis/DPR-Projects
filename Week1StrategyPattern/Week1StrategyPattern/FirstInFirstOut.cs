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
        public List<int> ProcessList()
        {
            requests.RemoveAt(0);
            Random rnd = new Random();
            requests.Add(rnd.Next(0, 100));
            return requests;
        }
    }
}
