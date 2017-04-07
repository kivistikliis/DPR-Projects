using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4FactoryPattern
{
    public class GenericGame
    {
        IFactory factory;
        IHouse house;
       
        //public GenericGame(IFactory f)
        //{
        //    factory=f;
        //}
        public String run()
        {
            return ("Game started");
        }

        public void setFactory(IFactory f)
        {
            factory = f;
            house = factory.createHouse();
        }

        public IFigure createFig(string name)
        {
            IFigure fig = factory.createFigure(name);
            return fig;
        }

        public IHouse createHouse()
        {
            return factory.createHouse();
        }

        public String sing(IFigure fig)
        {
            return fig.sing();
        }

        public String dance(IFigure fig)
        {
            return fig.dance();
        }

        public string FixHouse(IHouse house)
        {
            return house.repair();
        }

        public string GetHouseSize(IHouse house)
        {
            return house.measure();
        }


    }
}
