using System.Collections.Generic;

namespace DesignPatterns.FactoryMethod.PizzaStore
{
    public class SausagePizza : Pizza
    {
        public SausagePizza()
        {
            Name = "Sausage Pizza";
            Toppings = new List<string> { 
                "Sausage",
                "Caramelized onions",
                "Fennel"
            };
        }

        public override void Cut() 
        {

        }
    }
}
