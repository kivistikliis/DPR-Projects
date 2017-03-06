using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3DecoratorPattern
{
    public abstract class CondimentDecorator: IBeverage
    {
        protected IBeverage drink;
        public virtual decimal costs()
        {
            return 0;
        }
    }
}
