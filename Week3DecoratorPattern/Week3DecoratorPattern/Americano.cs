using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3DecoratorPattern
{
    public class Americano: IBeverage
    {
        public decimal costs()
        {
            return 2.5m;
        }
        public override String ToString()
        {
            return ("Americano " + this.costs());
        }
    }
}
