using System;
using DesignPatterns.FactoryMethod.PizzaStore;

namespace DesignPatterns.FactoryMethod
{
    public class FactoryLauncher : ILauncher
    {
        public void Run()
        {
            Console.WriteLine("********** PIZZA STORE **********");
            // Pizza Store
            new CompanyPizzaStore().OrderPizza("barbecue");
            new VegetarianPizzaStore().OrderPizza("spinach");

            Console.WriteLine(Environment.NewLine);
        }
    }
}
