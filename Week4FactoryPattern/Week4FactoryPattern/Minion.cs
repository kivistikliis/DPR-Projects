using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4FactoryPattern
{
    public class Minion:IFigure
    {
        public string Name;

        public Minion(string name)
        {
            Name = name;
        }
        public String dance()
        {
            return Name + " is dancing minion dance, huuulaaa!!!";
        }
        public String sing()
        {
            return Name + " is singing for minions";
        }

        public override string ToString()
        {
            return " Minion " + Name;
        }
       
    }
}
