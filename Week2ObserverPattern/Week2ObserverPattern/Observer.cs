using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week2ObserverPattern
{
    public class Observer:IObserver
    {
        Stock myStock;
        public double newvalue;
        public Observer(Stock newStock)
        {
            myStock=newStock;
            myStock.Attach(this);
        }
        public void Update()
        {
            newvalue = myStock.value;
        }
    }
}
