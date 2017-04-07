using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4FactoryPattern
{
   public class SmurfHouse : IHouse
    {
        private bool broken;
        private int size;
        private static int counter = 1;
        private int housenr;

        public SmurfHouse()
        {
            broken=true;
            size = 400;
            housenr = counter;
            counter++;
        }
        public String repair()
        {
            if (broken)
            {
                broken = false;
                return "Minion house " + housenr + " is now fixed";
            }
            else return "Minion house " + housenr + " is already fixed!";
        }
        public string measure()
        {
            return "Minion house " + housenr + " size is: " + GetSize();
        }

        public int GetSize()
        {
            return size + housenr;
        }

        public int GetHouseNr()
        {
            return housenr;
        }

        public override string ToString()
        {
            return "Smurf house nr:" + housenr;
        }
    }
}
