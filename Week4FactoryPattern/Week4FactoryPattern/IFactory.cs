using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4FactoryPattern
{
    interface IFactory
    {
        IFigure createMinion();
        IHouse createMinionHouse();
    }
}
