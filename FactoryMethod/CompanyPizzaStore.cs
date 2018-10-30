namespace DesignPatterns.FactoryMethod
{
    public class CompanyPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item) 
        {
            switch(item) {
                case "anchovy":
                    return new AnchovyPizza();
                case "sardine":
                    return new SardinePizza();
                case "barbecue":
                    return new BarbecuePizza();
                case "sausage":
                default:
                    return new SausagePizza();
            }
        }
    }
}