using System.Collections.Generic;

namespace DesignPatterns.FactoryMethod.PizzaStore
{
    public class SardinePizza : Pizza
    {
        public SardinePizza()
        {
            Name = "Sardine Pizza";
            Toppings = new List<string>
            {
                "Sardines",
                "Red onions",
                "Black olives"
            };
        }
    }
}
