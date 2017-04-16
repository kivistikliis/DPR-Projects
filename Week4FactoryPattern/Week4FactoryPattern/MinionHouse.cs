using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4FactoryPattern
{
   public class MinionHouse:IHouse
    {
        private bool broken;
        private int basesize=100;
        private static int counter =1;
        private int housenr;

        public MinionHouse()
        {
            broken=true;
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
            return "Minion house " + housenr+" size is: " + GetSize();
        }

        public int GetSize()
        {
            return basesize + housenr;
        }

        public int GetHouseNr()
        {
            return housenr;
        }

        public override string ToString(){
            return "Minion house nr:" + housenr;
        }
    }
}
