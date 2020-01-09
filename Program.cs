using System;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************** PIZZA STORE ****************************");
            // Pizza Store
            new CompanyPizzaStore().OrderPizza("barbecue");
            new VegetarianPizzaStore().OrderPizza("spinach");

            Console.Write(Environment.NewLine);

            Console.WriteLine("**************************** TIKI PAYMENT ****************************");
            // Tiki Payment
            new ClientStrategy().Perform();
        }
    }
}
