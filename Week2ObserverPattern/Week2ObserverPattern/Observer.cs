using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week2ObserverPattern
{
    public class Observer:IObserver
    {
        Stock myStock = new Stock();
        public double newvalue;
        public Form oform;
        
        public Observer(Stock newStock)
        {  
            myStock=newStock;
            newvalue = myStock.GetValue();
        }
        public void Update()
        {
            newvalue = myStock.GetValue();
        }
    }
}
