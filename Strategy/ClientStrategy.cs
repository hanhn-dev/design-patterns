using System;
using DesignPatterns.Models;

namespace DesignPatterns.Strategy
{
    public class ClientStrategy
    {
        public ClientStrategy() {}
        public void Perform() {
            var enteredValue = string.Empty;
            var methodValue = 0;
            var account = new Account();
            Console.WriteLine("Please choose one of following Payment Methods");
            var methods = Enum.GetValues(typeof(PaymentMethod));
            foreach (PaymentMethod method in methods) {
                Console.WriteLine($"{(int)method} {method}");
            }
            while(string.IsNullOrWhiteSpace(enteredValue)) {
                try
                {
                    enteredValue = Console.ReadLine();
                    methodValue = Convert.ToInt32(enteredValue);
                    SetAccount((PaymentMethod)methodValue, ref account);
                }
                catch(System.FormatException ex) 
                {
                    Console.WriteLine("The entered value is not correct format ! Please enter another one.", ex);
                    enteredValue = string.Empty;
                }
            }
            var paymentParams = new PaymentParam {
                Account = account
            };
            var paymentMethod = PaymentChooser.GetPaymentMethod((PaymentMethod)methodValue, paymentParams);
            var paymentProcessor = new PaymentProcessor(paymentMethod);
            paymentProcessor.Create();
        }

        private void SetAccount(PaymentMethod paymentMethod, ref Account account)
        {
            if(paymentMethod == PaymentMethod.MasterCard) 
            {
                do {
                    Console.Write("Please enter an account number: ");
                    var accountNumber = Console.ReadLine();
                    Console.Write("Please enter an account name: ");
                    var accountName = Console.ReadLine();
                    Console.Write("Please enter date expire: ");
                    var expiration = Console.ReadLine();
                    Console.Write("Please enter a code: ");
                    var code = Console.ReadLine();
                    account = new Account {
                        AccountName = accountName,
                        AccountNumber = accountNumber,
                        Code = code,
                        Expiration = DateTime.Parse(expiration)
                    };
                }  while(!ValidateAccount(account));
            }
        }
        
        private bool ValidateAccount(Account account) 
        {
            var result = account.Validate();
            if (!result.Item1) {
                foreach(string error in result.Item2) {
                    Console.WriteLine(error);
                }
            }
            return result.Item1;
        }
    }
}