using System;

namespace DesignPatterns.Strategy
{
    public class ZaloPay : Payment
    {
        public override void Process()
        {
            Console.WriteLine("Using ZaloPay");
        }
    }
}