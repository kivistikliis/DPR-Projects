using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4FactoryPattern
{
    class SmurfHouse : IHouse
    {
        private bool broken;
        private int size;
        public SmurfHouse()
        {
            broken=true;
            size = 999;
        }
        public String repair()
        {
            if (broken)
            {
                broken = false;
                return "Minion house is now fixed";
            }
            else return "Minion house is already fixed!";
        }
        public string measure()
        {
            return "Minion house size is: " + size;
        }
    }
}
