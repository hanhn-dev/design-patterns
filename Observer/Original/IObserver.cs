namespace DesignPatterns.Observer.Original
{
    public interface IObserver<T>
    {
        void Update(T t);
    }
}
