namespace DesignPatterns.Observer.RestaurantBusiness
{
    public interface IObserver<T>
    {
        void Update(T t);
    }
}
