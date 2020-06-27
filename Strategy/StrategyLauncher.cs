using System;

namespace DesignPatterns.Strategy
{
    public class StrategyLauncher : Launcher
    {
        public StrategyLauncher() : base("Strategy")
        {
        }

        public override void Run()
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
