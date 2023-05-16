using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Common
{
    public abstract class Subject : ISubject
    {
        private List<IObserver> observers;

        public Subject()
        {
            observers = new List<IObserver>();
        }

        public void Attach(in IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(in IObserver observer)
        {
            observers.Remove(observer);
        }

        protected void Notify()
        {
            foreach (IObserver o in observers)
            {
                o.Update(this);
            }
        }
    }
}
