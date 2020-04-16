using System;
namespace DesignPatterns.Mediator
{
    public class Tester : TeamMember
    {
        public Tester(string name) : base(name) { }

        public override void HandleNotification(string from, string message)
        {
            Console.WriteLine($"{from}: ${message}");
        }
    }
}
