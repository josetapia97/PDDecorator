using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCoffee
{
    public abstract class CoffeDecorator : ICoffee
    {
        protected ICoffee _coffee;
        public CoffeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }
        public virtual double GetCost()
        {
            return _coffee.GetCost();
        }

        public virtual string GetDescription()
        {
            return _coffee.GetDescription();
        }
    }
}
