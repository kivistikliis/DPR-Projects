using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week2ObserverPattern
{
    public interface IStock
    {
        void Attach(Observer o);
        void Detach(Observer o);
        void Notify();
    }
}
