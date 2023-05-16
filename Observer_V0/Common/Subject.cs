using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Common
{
    public abstract class Subject
    {
        private List<Observer> observers;

        public Subject()
        {
            observers = new List<Observer>();
        }

        public void Attach(in Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(in Observer observer)
        {
            observers.Remove(observer);
        }

        protected void Notify()
        {
            foreach (Observer o in observers)
            {
                o.Update(this);
            }
        }
    }
}
