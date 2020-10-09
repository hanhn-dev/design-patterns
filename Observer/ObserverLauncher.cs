using DesignPatterns.Observer.Original;
using DesignPatterns.Observer.RestaurantBusiness;

namespace DesignPatterns.Observer
{
    public class ObserverLauncher : Launcher
    {
        public ObserverLauncher() : base("Observer")
        {
        }

        public override void Run()
        {
            // Original();
            Practical();
        }

        private static void Original()
        {
            var observable = new ConcreteObservable(new[] {1,2,3,4,5});
            var observer = new ConcreteObserver();

            observable.Add(observer);

            observable.Notify();
        }

        private static void Practical()
        {
            var restaurant = new Restaurant();
            restaurant.Run();
        }
    }
}
