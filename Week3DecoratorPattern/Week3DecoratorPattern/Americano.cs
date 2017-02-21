using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3DecoratorPattern
{
    public class Americano: IBeverage
    {
        public double costs()
        {
            return 2.5;
        }
        public String orderDetails()
        {
            return "An americano";
        }
    }
}
