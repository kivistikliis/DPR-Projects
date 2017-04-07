using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4FactoryPattern
{
    public interface IFactory
    {
        IFigure createFigure(string name);
        IHouse createHouse();
    }
}
