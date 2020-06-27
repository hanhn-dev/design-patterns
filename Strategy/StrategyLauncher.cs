using System;

namespace DesignPatterns.Strategy
{
    public class StrategyLauncher : ILauncher
    {
        public void Run()
        {
            TikiPaymentExample();
        }

        private void TikiPaymentExample()
        {
            Console.WriteLine("********** TIKI PAYMENT **********");
            // Tiki Payment
            new ClientStrategy().Perform();

            Console.WriteLine(Environment.NewLine);
        }
    }
}
