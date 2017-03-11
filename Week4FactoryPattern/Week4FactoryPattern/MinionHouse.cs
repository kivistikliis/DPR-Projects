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
        public MinionHouse()
        {
            broken=false;
            size = 100;
        }
        public void repair()
        {
            broken = true;
        }
        public int measure()
        {
            return size;
        }
    }
}
