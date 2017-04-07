using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4FactoryPattern
{
   public class MinionFactory:IFactory
    {
        public IFigure createFigure(string name)
        {
            return (new Minion(name));
        }
        public IHouse createHouse()
        {
            return (new MinionHouse());
        }

        public override string ToString()
        {
            return "Minion game";
        }
    }
}
