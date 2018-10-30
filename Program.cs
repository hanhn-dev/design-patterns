using System;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Models;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            // Pizza Store
            new CompanyPizzaStore().OrderPizza("barbecue");
            new VegetarianPizzaStore().OrderPizza("spinach");

            // Tiki Payment
            // new ClientStrategy().Perform();
        }
    }
}
