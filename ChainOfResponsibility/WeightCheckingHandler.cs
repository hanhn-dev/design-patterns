namespace DesignPatterns.ChainOfResponsibility
{
    public class WeightCheckingHandler : Handler<CoffeePackage>
    {
        public override void Handle(CoffeePackage coffeePackage)
        {
            if (coffeePackage.Weight < 100)
            {
                throw new System.Exception("This package of coffee is not enough weight to make a cup of coffee");
            }

            base.Handle(coffeePackage);
        }
    }
}
