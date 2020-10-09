namespace DesignPatterns.Observer.Original
{
    public interface IObservable<T>
    {
        void Add(IObserver<T> observer);
        void Remove(IObserver<T> observer);
        void Notify();
    }
}
