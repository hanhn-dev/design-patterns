namespace DesignPatterns.Observer.Original
{
    public class ConcreteObserver : IObserver<int>
    {
        public void Update(int number)
        {
            System.Console.WriteLine($"I got new number {number}.");
        }
    }
}
