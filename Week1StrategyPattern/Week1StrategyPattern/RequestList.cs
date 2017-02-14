using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1StrategyPattern
{
    public class RequestList
    {
        public IProcessMode processmode;
        public List<int> processlist;
        public int currentValue;
        public RequestList()
        {
            processlist = new List<int>();


            Random r = new Random();
            for (int i = 0; i < 15; i++)
            {
                processlist.Add(r.Next(0, 100));
                
            }
        }
        

        //This method processes one request, returns int as the number to be removed
        public int Process(int currentValue)

        {
            this.currentValue = currentValue;
            return processmode.ProcessList(processlist,currentValue);
        }

        
    }
}
