using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCoffee.Elements.CoffeAdds
{
    public class SimpleCoffee : ICoffee
    {
        public double GetCost()
        {
            return 1.0;
        }

        public string GetDescription()
        {
            return "Simple coffe";
        }
    }
}
