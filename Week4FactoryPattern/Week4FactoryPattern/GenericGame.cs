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
           figure = factory.createFigure();
           Console.WriteLine(figure.sing());
           Console.WriteLine(figure.dance());

            house = factory.createHouse();
            Console.WriteLine (house.measure());
            house.repair();

            return "You have one Minion and one House";
        }

    }
}
