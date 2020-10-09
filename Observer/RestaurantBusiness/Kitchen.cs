using System;
using System.Collections.Generic;
using System.Threading;

namespace DesignPatterns.Observer.RestaurantBusiness
{
    public class Kitchen : IObservable<OrderedFood>
    {
        private readonly List<IObserver<OrderedFood>> _observers = new List<IObserver<OrderedFood>>();

        private readonly Queue<OrderedFood> _orderedFoods = new Queue<OrderedFood>();
        
        public void Add(IObserver<OrderedFood> observer)
        {
            _observers.Add(observer);
        }

        public void Remove(IObserver<OrderedFood> observer)
        {
            _observers.Remove(observer);
        }

        public void AddOrderedFood(OrderedFood orderedFood)
        {
            _orderedFoods.Enqueue(orderedFood);
        }

        public void Notify()
        {
            foreach (var orderedFood in _orderedFoods)
            {
                Thread.Sleep(2000);
                Console.WriteLine($"The food {orderedFood.Name} for the Table {orderedFood.Table} has done !");
                Thread.Sleep(500);
                Push(orderedFood);
            }
        }

        private void Push(OrderedFood orderedFood)
        {
            foreach (var observer in _observers)
            {
                observer.Update(orderedFood);
            }
        }
    }
}