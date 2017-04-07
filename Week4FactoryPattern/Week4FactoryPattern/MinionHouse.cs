using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4FactoryPattern
{
    class MinionHouse:IHouse
    {
        private bool broken;
        private int size;
        private static int counter =1;
        private int housenr;

        public MinionHouse()
        {
            broken=true;
            size = 100;
            housenr=counter;
            counter++;

        }
        public string repair()
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
            return "Minion house " + housenr+" size is: " + size+housenr;
        }

        public override string ToString(){
            return "Minion house nr:" + housenr;
        }
    }
}
