using Observer_V2.Common;

namespace ObserverPattern.Common
{
    public interface ISubject
    {
        void Attach(in NotifyHandler action);
        void Detach(in NotifyHandler action);
    }
}