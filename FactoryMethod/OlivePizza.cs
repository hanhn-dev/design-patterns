using System.Collections.Generic;

namespace DesignPatterns.FactoryMethod
{
    public class OlivePizza : Pizza
    {
        public OlivePizza()
        {
            Name = "Olive Pizza";
            Toppings = new List<string>
            {
                "Olive oil with paper-thin sliced potatoes",
                "Sage",
                "Fontina cheese"
            };
        }
    }
}