using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class BrandCheckingHandler : Handler<CoffeePackage>
    {
        public override void Handle(CoffeePackage coffeePackage)
        {
            if (coffeePackage.Brand == CoffeeBrand.Nestle)
            {
                throw new Exception("This coffee type is not sutiable for making a cup of coffee.");
            }

            base.Handle(coffeePackage);
        }
    }
}
