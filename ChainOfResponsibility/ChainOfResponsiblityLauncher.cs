using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class ChainOfResponsibilityLauncher : Launcher
    {
        public ChainOfResponsibilityLauncher() : base("Chain of Reponsibility")
        {
        }

        public override void Run()
        {
            Console.WriteLine("********** Making a cup of Coffee **********");

            var coffeePackage = new CoffeePackage()
            {
                Brand = CoffeeBrand.G7,
                Weight = 100m,
                Type = CoffeeType.Black
            };

            var process = new CoffeeMakingProcess();

            process.Handle(coffeePackage);
        }
    }
}
