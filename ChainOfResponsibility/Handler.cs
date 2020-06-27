namespace DesignPatterns.ChainOfResponsibility
{
    public class Handler<T> : IHandler<T>
    {
        protected IHandler<T> Next;

        public virtual void Handle(T request)
        {
            Next?.Handle(request);
        }

        public virtual IHandler<T> SetNextHandler(IHandler<T> nextHandler)
        {
            Next = nextHandler;

            return Next;
        }
    }
}
