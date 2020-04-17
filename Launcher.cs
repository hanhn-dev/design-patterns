using System;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Mediator.Original;
using DesignPatterns.Singleton;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    public static class Launcher
    {
        public static void RunSingletonPattern()
        {
            Console.WriteLine("********** Singleton Pattern **********");
            LoadBalancer instance1 = LoadBalancer.GetInstance();
            LoadBalancer instance2 = LoadBalancer.GetInstance();

            if(instance1 == instance2)
            {
                Console.WriteLine("Two instances are the same !");
            }
            else
            {
                Console.WriteLine("Two instances are not equal !");
            }
        }

        public static void RunMediatorPattern()
        {
            Console.WriteLine("********** Mediator Pattern **********");
            var mediator = new ConcreteMediator();

            var colleague1 = mediator.CreateColleague<Colleague1>();
            var colleague2 = mediator.CreateColleague<Colleague2>();

            colleague1.Send("Hi there ! How are you today ? (from colleague1)");
            colleague2.Send("Hi there ! Are you happy with the current position ? (from colleague2)");

            Console.WriteLine(Environment.NewLine);
        }

        public static void RunFactoryMethodPattern()
        {
            Console.WriteLine("********** PIZZA STORE **********");
            // Pizza Store
            new CompanyPizzaStore().OrderPizza("barbecue");
            new VegetarianPizzaStore().OrderPizza("spinach");

            Console.WriteLine(Environment.NewLine);
        }

        public static void RunStrategyPattern()
        {
            Console.WriteLine("********** TIKI PAYMENT **********");
            // Tiki Payment
            new ClientStrategy().Perform();

            Console.WriteLine(Environment.NewLine);
        }
    }
}
