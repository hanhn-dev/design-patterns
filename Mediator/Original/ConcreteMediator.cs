using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Mediator.Original
{
    public class ConcreteMediator : Mediator
    {
        private List<Colleague> _colleagues = new List<Colleague>();

        public T CreateColleague<T>() where T : Colleague, new()
        {
            var colleague = new T();
            colleague.SetMediator(this);
            _colleagues.Add(colleague);
            return colleague;
        }

        public override void Send(string message, Colleague colleague)
        {
            _colleagues.Where(m => m != colleague).ToList().ForEach(c => c.HandleNotification(message));
        }
    }
}
