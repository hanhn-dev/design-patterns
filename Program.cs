using System.Collections.Generic;
using DesignPatterns.Composite;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Mediator;
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
            
            foreach (var launcher in launchers)
            {
                launcher.Run();
            }
        }
    }
}
