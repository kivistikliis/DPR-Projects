using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3DecoratorPattern
{
    public abstract class CondimentDecorator: IBeverage
    {
        protected IBeverage drink;
        public double costs()
        {
            return 0;
        }
        public String orderDetails()
        {
            return "";
        }
    }
}
