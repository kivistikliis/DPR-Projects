using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3DecoratorPattern
{
    class Mochachino: IBeverage
    {
        public decimal costs()
        {
            return 2;
        }
        public override String ToString()
        {
            return ("Mochachino " + this.costs());
        }
    }
}
