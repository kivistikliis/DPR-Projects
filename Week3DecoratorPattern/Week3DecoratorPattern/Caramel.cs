using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3DecoratorPattern
{
    public class Caramel:CondimentDecorator
    {
        public Caramel(IBeverage b)
            :base()
        {
            this.drink = b;
        }
    }
}
