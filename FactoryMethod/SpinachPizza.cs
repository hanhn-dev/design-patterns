using System;
using System.Collections.Generic;

namespace DesignPatterns.FactoryMethod
{
    public class SpinachPizza : Pizza
    {
        public SpinachPizza()
        {
            Name = "Spinach Pizza";
            Toppings = new List<string>
            {
                "Spinach",
                "Artichoke hearts",
                "Garlic",
                "Red onion"
            };
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting into 18 slices");
        }

        public override void Box()
        {
            Console.WriteLine("Place the pizza in a box with Lotus flower logo");
        }
    }
}