using System;

namespace DesignPatterns.Strategy
{
    public class InternetBanking : Payment
    {
        public override void Process()
        {
            Console.WriteLine("Using Internet Banking");
        }
    }
}