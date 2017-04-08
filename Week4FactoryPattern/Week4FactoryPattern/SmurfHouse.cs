using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4FactoryPattern
{
   public class SmurfHouse : IHouse
    {
        private bool broken;
        private int basesize=400;
        private static int counter = 1;
        private int housenr;

        public SmurfHouse()
        {
            broken=true;
            housenr = counter;
            counter++;
        }
        public String repair()
        {
            if (broken)
            {
                broken = false;
                return "Smurf house " + housenr + " is now fixed";
            }
            else return "Smurf house " + housenr + " is already fixed!";
        }
        public string measure()
        {
            return "Smurf house " + housenr + " size is: " + GetSize();
        }

        public int GetSize()
        {
            return basesize + housenr;
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
