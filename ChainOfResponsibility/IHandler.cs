namespace DesignPatterns.ChainOfResponsibility
{
    public interface IHandler<T>
    {
        IHandler<T> SetNextHandler(IHandler<T> nextHandler);
        void Handle(T request);
    }
}
