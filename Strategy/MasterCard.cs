using System;
using DesignPatterns.Models;

namespace DesignPatterns.Strategy
{
    public class MasterCard : Payment
    {
        private readonly Account UserAccount;
        public MasterCard(Account userAccount) : base()
        {
            UserAccount = userAccount;
        }
        public override void Process()
        {
            Console.WriteLine("Using MasterCard");
        }
    }
}