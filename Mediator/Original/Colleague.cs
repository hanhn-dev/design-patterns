namespace DesignPatterns.Mediator.Original
{
    public abstract class Colleague
    {
        protected Mediator _mediator;
        
        public void SetMediator(Mediator mediator) 
        {
            _mediator = mediator;
        }

        public void Send(string message)
        {
            _mediator.Send(message, this);
        }

        public abstract void HandleNotification(string message);
    }
}
