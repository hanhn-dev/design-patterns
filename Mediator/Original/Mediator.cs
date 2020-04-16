using System;
namespace DesignPatterns.Mediator.Original
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}
