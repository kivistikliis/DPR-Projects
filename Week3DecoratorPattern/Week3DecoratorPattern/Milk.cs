using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3DecoratorPattern
{
    public class Milk: CondimentDecorator
    {
        public Milk(IBeverage b)
            :base()
        {
            this.drink = b;
        }
    }
}
