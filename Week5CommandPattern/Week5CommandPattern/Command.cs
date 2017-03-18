using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5CommandPattern
{
    public interface Command
    {
        String execute();
        String undo();
    }
}
