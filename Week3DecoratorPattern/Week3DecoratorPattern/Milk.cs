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

        public override decimal costs()
        {

            return 0.40m + this.drink.costs(); ;
        }

        public override String ToString()
        {
            return this.drink.ToString() + " with Milk (0.40 eur)";
        }
    }
}
