using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorBurger.Elements.BurgerTypes
{
    public class TomatoDecorator : BurgerDecorator
    {
        public TomatoDecorator(IBurger burger) : base(burger)
        {

        }
        public override string GetDescription()
        {
            return _burger.GetDescription()+", tomato";
        }
        public override double GetCost()
        {
            return _burger.GetCost() + 0.2;
        }
    }
}
