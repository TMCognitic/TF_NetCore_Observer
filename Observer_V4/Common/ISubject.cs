using Observer_V2.Common;

namespace ObserverPattern.Common
{
    public interface ISubject
    {
        event NotifyHandler? Handler;
    }
}