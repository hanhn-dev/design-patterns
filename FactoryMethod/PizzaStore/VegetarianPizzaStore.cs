namespace DesignPatterns.FactoryMethod.PizzaStore
{
    public class VegetarianPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            switch(item) 
            {
                case "spinach":
                    return new SpinachPizza();
                case "olive":
                    return new OlivePizza();
                case "fennel":
                default:
                    return new FennelPizza();
            }
        }
    }
}
