using System;
using System.Collections.Generic;

namespace DesignPatterns.FactoryMethod.PizzaStore
{
    public class AnchovyPizza : Pizza
    {
        public AnchovyPizza()
        {
            Name = "Anchovy Pizza";
            Toppings = new List<string>
            {
                "Anchovies",
                "Tomato",
                "Ricotta",
                "Mustard greens"
            };
        }

        public override void Cut()
        {
            Console.WriteLine("Cuting six pieces into a curvy star-shape from the center");
        }
    }
}
