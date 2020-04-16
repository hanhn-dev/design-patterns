using System;
namespace DesignPatterns.Mediator
{
    public abstract class TeamMember
    {
        public string Name { get; set; }
        public TeamMember(string name)
        {
            Name = name;
        }

        public abstract void HandleNotification(string from, string message);
    }
}
