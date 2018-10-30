namespace DesignPatterns.Strategy
{
    public class PaymentProcessor
    {
        private Payment PaymentProcess;
        public PaymentProcessor()
        {
            PaymentProcess = new Cash();
        }

        public PaymentProcessor(Payment process) {
            PaymentProcess = process;
        }

        public void SetPaymentProcess(Payment process) {
            PaymentProcess = process;
        }

        public void Create() 
        {
            PaymentProcess.Process();
        }
    }
}