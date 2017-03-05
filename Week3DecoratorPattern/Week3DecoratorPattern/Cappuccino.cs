using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3DecoratorPattern
{
    public class Cappuccino:IBeverage
    {
        public decimal costs()
        {
            return 1.7m;
        }
        public override String ToString()
        {
            return ("Cappuccino " +this.costs());
        }
    }
}
