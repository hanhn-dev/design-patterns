using System;
using System.Collections.Generic;
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.Composite;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Mediator;
using DesignPatterns.Observer;
using DesignPatterns.Singleton;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var launchers = new List<ILauncher>();
            launchers.Add(new CompositeLauncher());
            launchers.Add(new FactoryLauncher());
            launchers.Add(new MediatorLauncher());
            launchers.Add(new SingletonLauncher());
            launchers.Add(new StrategyLauncher());
            launchers.Add(new ChainOfResponsibilityLauncher());
            launchers.Add(new ObserverLauncher());

            Console.WriteLine("**************** Select a Pattern *******************");
            
            for(var i = 1; i <= launchers.Count; i++)
            {
                Console.WriteLine($"{i}. {launchers[i-1].Name}");
            }

            var userSelected = Console.ReadLine();

            if (int.TryParse(userSelected, out var pattern))
            {
                var launcher = launchers[pattern-1];
                Console.WriteLine($"You have selected the pattern: {launcher.Name}");
                launcher.Run();
            }
            else
            {
                Console.WriteLine("Couldn't find your selected pattern !");
            }
        }
    }
}
