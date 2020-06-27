using System;

namespace DesignPatterns.Singleton
{
    public class SingletonLauncher : Launcher
    {
        public SingletonLauncher() : base("Singleton")
        {
        }

        public override void Run()
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
    }
}
