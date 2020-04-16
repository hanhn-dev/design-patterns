using System;
namespace DesignPatterns.Mediator
{
    public class Developer : TeamMember
    {
        public Developer(string name) : base(name) { }

        public override void HandleNotification(string from, string message)
        {
            throw new NotImplementedException();
        }
    }
}
