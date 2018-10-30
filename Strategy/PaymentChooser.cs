using System;
using DesignPatterns.Models;

namespace DesignPatterns.Strategy
{
    public class PaymentChooser
    {
        public static Payment GetPaymentMethod(PaymentMethod method, PaymentParam param = null) 
        {
            switch(method) {
                case PaymentMethod.Cash:
                    return new Cash();
                case PaymentMethod.ZaloPay:
                    return new ZaloPay();
                case PaymentMethod.Momo:
                    return new Momo();
                case PaymentMethod.InternetBanking:
                    return new InternetBanking();
                case PaymentMethod.MasterCard:
                    return new MasterCard(param.Account);
                default:
                    return new Cash();
            }
        }
    }
}