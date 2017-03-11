using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4FactoryPattern
{
    class MinionFactory:IFactory
    {
        public IFigure createMinion()
        {
            return (new Minion());
        }
        public IHouse createMinionHouse()
        {
            return (new MinionHouse());
        }
    }
}
