using System;

namespace DesignPatterns.Observer.RestaurantBusiness
{
    public class Actor : IObserver<OrderedFood>
    {
        public void Update(OrderedFood t)
        {
            Console.WriteLine($"I'm going to get the food {t.Name}.");
        }
    }
}