namespace ObserverPattern.Common
{
    public interface ISubject
    {
        void Attach(in IObserver observer);
        void Detach(in IObserver observer);
    }
}