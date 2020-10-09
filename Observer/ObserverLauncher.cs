using DesignPatterns.Observer.Original;

namespace DesignPatterns.Observer
{
    public class ObserverLauncher : Launcher
    {
        public ObserverLauncher() : base("Observer")
        {
        }

        public override void Run()
        {
            var observable = new ConcreteObservable(new[] {1,2,3,4,5});
            var observer = new ConcreteObserver();

            observable.Add(observer);

            observable.Notify();
        }
    }
}
