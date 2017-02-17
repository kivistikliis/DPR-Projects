using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week2ObserverPattern
{
    public class Stock:IStock
    {
        private double value = 12;
       private static List<Observer> observers = new List<Observer>();

        public void ChangeValue(double newvalue)
        {
            value = newvalue;
            this.Notify();
        }

        public double GetValue()
        {
            return value;
        }
        public void Attach(Observer o)
        {
            observers.Add(o);
        }
        public void Detach(Observer o)
        {
            observers.Remove(o);
        }
        public void Notify()
        {
            for (int i = 0; i < observers.Count; i++)
                observers[i].Update();
        }

        public int GetNrOfAttachedObservers()
        {
            return observers.Count();
        }
    }
}
