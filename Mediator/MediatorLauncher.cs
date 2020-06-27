using System;
using DesignPatterns.Mediator.Original;

namespace DesignPatterns.Mediator
{
    public class MediatorLauncher : ILauncher
    {
        public void Run()
        {
            Console.WriteLine("********** Mediator Pattern **********");
            var mediator = new ConcreteMediator();

            var colleague1 = mediator.CreateColleague<Colleague1>();
            var colleague2 = mediator.CreateColleague<Colleague2>();

            colleague1.Send("Hi there ! How are you today ? (from colleague1)");
            colleague2.Send("Hi there ! Are you happy with the current position ? (from colleague2)");

            Console.WriteLine(Environment.NewLine);
        }
    }
}
