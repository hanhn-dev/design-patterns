using System.Collections.Generic;

namespace DesignPatterns.FactoryMethod
{
    public class FennelPizza : Pizza
    {
        public FennelPizza()
        {
            Name = "Fennel Pizza";
            Toppings = new List<string> 
            {
                "Caramelized fennel",
                "Onion",
                "Olives",
                "Fontina cheese"
            };
        }
    }
}