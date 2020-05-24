using System;
using DesignPatterns.Composite;
using DesignPatterns.FactoryMethod.PizzaStore;
using DesignPatterns.Mediator.Original;
using DesignPatterns.Singleton;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    public static class Launcher
    {
        public static void RunCompositePattern()
        {
            Console.WriteLine("********** File System **********");
            var root = new DirectoryItem("projects");
            var project1 = new DirectoryItem("project1");
            var item1Project1 = new FileItem("ItemTxt1", 2100);
            var item2Project1 = new FileItem("ItemTxt2", 3100);
            var project11 = new DirectoryItem("project1.1");
            var item1Project11 = new FileItem("ItemTxt1.1", 4100);
            var item2Project11 = new FileItem("ItemTxt2.1", 5100);            
            project11.Add(item1Project11);
            project11.Add(item2Project11);
            project1.Add(item1Project1);
            project1.Add(item2Project1);
            project1.Add(project11);
            var project2 = new DirectoryItem("project2");
            
            root.Add(project1);
            root.Add(project2);

            Console.WriteLine($"Total byte sizes: {root.GetSizeInKb()}");
        }

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
