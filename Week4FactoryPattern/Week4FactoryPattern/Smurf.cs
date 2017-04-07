using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4FactoryPattern
{
    public class Smurf : IFigure
    {

        public string Name;

        public Smurf(string name)
        {
            Name = name;
        }
        public String dance()
        {
            return Name + " is dancing smurf dance!";
        }
        public String sing()
        {
            return Name + " is singing a smurfsong";
        }
        public override string ToString()
        {
            return " Smurf " + Name;
        }
    }
}
