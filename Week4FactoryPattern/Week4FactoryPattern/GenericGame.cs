using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4FactoryPattern
{
    class GenericGame
    {
        IFactory factory;
        IHouse house;
        List<IFigure> figures;
       
        public GenericGame(IFactory f)
        {
            factory=f;
            figures = new List<IFigure>();
        }
        public String run()
        {
            house = factory.createHouse();
            return ("Game started: " + factory.ToString());
        }

        public void setFactory(IFactory f)
        {
            factory = f;
        }

        public IFigure createFig(string name)
        {
            IFigure fig = factory.createFigure(name);
            figures.Add(fig);

            return fig;
        }

        public String sing(IFigure fig)
        {
            return fig.sing();
        }

        public String dance(IFigure fig)
        {
            return fig.dance();
        }

        public string FixHouse()
        {
            return house.repair();
        }

        public string GetHouseSize()
        {
            return house.measure();
        }



    }
}
