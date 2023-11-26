using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCoffee.Elements.CoffeTypes
{
    public class WhippedCreamDecorator : CoffeDecorator
    {
        public WhippedCreamDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", whipped cream";
        }

        public override double GetCost()
        {
            return _coffee.GetCost() + 0.3;
        }
    }
}
