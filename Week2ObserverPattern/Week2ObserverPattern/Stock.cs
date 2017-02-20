using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week2ObserverPattern
{
    public class Stock:IStock
    {
        private double value = 12;
        private List<IObserver> observers = new List<IObserver>();

        public void ChangeValue(double newvalue)
        {
            value = newvalue;
            this.Notify();
        }

        public double GetValue()
        {
            return value;
        }
        public void Attach(IObserver o)
        {
            observers.Add(o);
        }
        public void Detach(IObserver o)
        {
            observers.Remove(o);
        }
        public void Notify()
        {
            for (int i = 0; i < observers.Count; i++)
                observers[i].Update(value);
        }

        public int GetNrOfAttachedObservers()
        {
            return observers.Count();
        }
    }
}
