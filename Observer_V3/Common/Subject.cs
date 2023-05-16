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

        public void Attach(in NotifyHandler action)
        {
            _handler += action;
        }

        public void Detach(in NotifyHandler action)
        {
            _handler -= action;
        }

        protected void Notify()
        {
            _handler?.Invoke(this);
        }
    }
}
