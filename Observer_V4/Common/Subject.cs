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
        public event NotifyHandler? Handler;        

        protected void Notify()
        {
            Handler?.Invoke(this);
        }
    }
}
