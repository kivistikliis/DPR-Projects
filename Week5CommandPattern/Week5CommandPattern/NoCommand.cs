using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5CommandPattern
{
    class NoCommand:Command
    {
        public String execute()
        {
            return "";
        }
        public String undo()
        {
            return "";
        }
    }
}
