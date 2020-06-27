using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class CoffeeMakingProcess
    {
        public void Handle(CoffeePackage coffeePackage)
        {
            var handler = new BrandCheckingHandler();

            handler.SetNextHandler(new WeightCheckingHandler());

            try
            {
                handler.Handle(coffeePackage);
                System.Console.WriteLine("A cup of coffee has been made.");
            }
            catch(Exception exception)
            {
                System.Console.WriteLine($"No cup of coffee has been made due to {exception.Message}");
            }
        }
    }
}
