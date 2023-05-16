using Observer_V2.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Common
{
    public abstract class Subject : ISubject
    {
        private NotifyHandler? _handler;

        public void Attach(in IObserver observer)
        {
            _handler += observer.Update;
        }

        public void Detach(in IObserver observer)
        {
            _handler -= observer.Update;
        }

        protected void Notify()
        {
            _handler?.Invoke(this);
        }
    }
}
