namespace DesignPatterns.Strategy
{
    public abstract class Payment : IPaymentProcess
    {
        protected Payment()
        {
            
        }

        public abstract void Process();
    }
}