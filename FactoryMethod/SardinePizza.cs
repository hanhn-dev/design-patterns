using System.Collections.Generic;

namespace DesignPatterns.FactoryMethod
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