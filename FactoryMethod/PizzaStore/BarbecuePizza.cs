using System;

namespace DesignPatterns.FactoryMethod.PizzaStore
{
    public class BarbecuePizza : Pizza
    {
        public BarbecuePizza()
        {
            Name = "Barbecue Pizza";
            Toppings = new System.Collections.Generic.List<string>
            {
                "Barbecue sauce",
                "Topped with grilled chicken",
                "Cheddar cheese"
            };
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting into 18 slices !");
        }
    }   
}
