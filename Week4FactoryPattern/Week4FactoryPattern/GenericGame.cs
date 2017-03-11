using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4FactoryPattern
{
    class GenericGame
    {
        IFactory factory;
        IFigure figure;
        IHouse house;
        public GenericGame(IFactory f)
        {
            factory=f;
        }
        public String run()
        {
            figure = factory.createMinion();
            figure.sing();
            figure.dance();

            house = factory.createMinionHouse();
            house.measure();
            house.repair();

            return "You have one Minion and one House";
        }

    }
}
