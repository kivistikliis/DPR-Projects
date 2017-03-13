using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4FactoryPattern
{
    class MinionFactory:IFactory
    {
        public IFigure createFigure()
        {
            return (new Minion());
        }
        public IHouse createHouse()
        {
            return (new MinionHouse());
        }
    }
}
