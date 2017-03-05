using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3DecoratorPattern
{
    public class Soy:CondimentDecorator
    {
        public Soy(IBeverage b)
            :base()
        {
            this.drink = b;
        }

        public override decimal costs()
        {
            return 0.50m + this.drink.costs();
        }

        public override String ToString()
        {
            return this.drink.ToString() + " with Soy (0.50 eur) ";
        }
    }
}
