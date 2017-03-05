using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3DecoratorPattern
{
    public interface IBeverage
    {
        decimal costs();
        String ToString();
    }
}
