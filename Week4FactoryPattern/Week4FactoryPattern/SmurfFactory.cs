using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4FactoryPattern
{
    public class SmurfFactory : IFactory
    {
        public IFigure createFigure(string name)
        {
            return (new Smurf(name));
        }
        public IHouse createHouse()
        {
            return (new SmurfHouse());
        }

        public override string ToString()
        {
            return "Smurf game";
        }
    }
}
