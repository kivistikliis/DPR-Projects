using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3DecoratorPattern
{
    class Mochachino: IBeverage
    {
        public double costs()
        {
            return 2;
        }
        public String orderDetails()
        {
            return "A mochachino";
        }
    }
}
