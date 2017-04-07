using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4FactoryPattern
{
    public interface IHouse
    {
        string repair();
        string measure();
        int GetHouseNr();
        int GetSize();
    }
}
