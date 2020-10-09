using System.Collections.Generic;
using System.Threading;

namespace DesignPatterns.Observer.Original
{
    public class ConcreteObservable : IObservable<int>
    {
        private List<IObserver<int>> _observers = new List<IObserver<int>>();
        private readonly int[] _integers;

        public ConcreteObservable(int[] integers)
        {
            _integers = integers;
        }

        public void Add(IObserver<int> observer)
        {
            _observers.Add(observer);
        }

        public void Notify()
        {
            foreach(var integer in _integers)
            {
                System.Console.WriteLine($"I have new integer {integer}.");
                Thread.Sleep(2000);
                Push(integer);
            }
        }

        public void Remove(IObserver<int> observer)
        {
            _observers.Remove(observer);
        }

        private void Push(int number)
        {
            foreach (var observer in _observers)
            {
                observer.Update(number);
            }
        }
    }
}
