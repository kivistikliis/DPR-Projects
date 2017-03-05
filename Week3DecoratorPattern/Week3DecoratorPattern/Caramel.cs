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

        public override decimal costs()
        {
            return 0.30m + this.drink.costs();
        }

        public override String ToString()
        {
            return this.drink.ToString() + " with Caramel (0.30 eur) ";
        }
    }
}
