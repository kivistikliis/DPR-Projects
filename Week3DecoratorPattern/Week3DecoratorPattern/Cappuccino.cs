using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3DecoratorPattern
{
    public class Cappuccino:IBeverage
    {
        public double costs()
        {
            return 1.7;
        }
        public String orderDetails()
        {
            return "A cappuccino";
        }
    }
}
