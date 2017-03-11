using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4FactoryPattern
{
    class Minion:IFigure
    {
        public String dance()
        {
            return "I am dancing, huuulaaa!!!";
        }
        public String sing()
        {
            return "Look at me, i am singing!!!";
        }
        public String cook()
        {
            return "I am bakin' cookies!!!";
        }
        public int calculate(int a, int b)
        {
            return a + b;
        }
    }
}
