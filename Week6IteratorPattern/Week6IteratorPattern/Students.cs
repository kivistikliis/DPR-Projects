using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6IteratorPattern
{
    public class Students
    {
        Class ei4s1Class, ei4s2Class;

        public void createEI4S1()
        {
            ei4s1Class = new EI4S1();
        }
        public void createEI4S2()
        {
            ei4s2Class = new EI4S2();
        }
        public Iterator createEI4S1Iterator()
        {
            return ei4s1Class.createIterator();
        }
        public Iterator createEI4S2Iterator()
        {
            return ei4s2Class.createIterator();
        }
    }
}
