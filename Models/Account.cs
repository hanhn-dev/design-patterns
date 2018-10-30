using System;
using System.Collections.Generic;

namespace DesignPatterns.Models
{
    public class Account 
    {
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public DateTime Expiration { get; set; }
        public string Code { get; set; }

        public Tuple<bool, List<string>> Validate()
        {
            var flag = true;
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(AccountNumber)) 
            {
                errors.Add("Account Number must be required !");
                flag = false;
            }

            if (string.IsNullOrWhiteSpace(AccountName)) 
            {
                errors.Add("Account Name must be required !");
                flag = false;
            }

            if (Expiration < DateTime.Now) 
            {
                errors.Add("Account is out of dated !");
                flag = false;
            }

            if (!string.IsNullOrWhiteSpace(Code) && Code.Length > 3) 
            {
                errors.Add("Entered Code is not valid !");
                flag = false;
            }

            return Tuple.Create(flag, errors);
        }
    }
}