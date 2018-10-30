using System;

namespace DesignPatterns.Strategy
{
    public class Cash : Payment
    {
        public override void Process()
        {
            Console.WriteLine("Using Cash");
        }
    }
}