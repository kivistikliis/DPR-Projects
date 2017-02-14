using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week2ObserverPattern
{
    public class Stock:IStock
    {
        private string item = "Gold";
        private double value = 12.5;
        List<Observer> observers = new List<Observer>();

        public void ChangeValue(int newvalue)
        {
            value = newvalue;
            this.Notify();
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
    }
}
