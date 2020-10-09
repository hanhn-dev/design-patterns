namespace DesignPatterns.Observer.RestaurantBusiness
{
    public class Restaurant
    {
        public void Run()
        {
            var kitchen = new Kitchen();
            var actor = new Actor();
            
            kitchen.Add(actor);
            kitchen.AddOrderedFood(new OrderedFood() { Name = "Pizza", Table = 1 });
            kitchen.AddOrderedFood(new OrderedFood() { Name = "French Fried", Table = 2 });
            kitchen.AddOrderedFood(new OrderedFood() { Name = "Coke", Table = 2 });
            kitchen.AddOrderedFood(new OrderedFood() { Name = "Ice cream", Table = 3});

            kitchen.Notify();
        }
    }
}