namespace DesignPatterns.ChainOfResponsibility
{
    public class CoffeePackage
    {
        public Coffee Coffee { get;set; }
        public decimal Weight { get; set; }
        public CoffeeType Type { get; set; }
        public CoffeeBrand Brand { get; set; }
    }    
}
