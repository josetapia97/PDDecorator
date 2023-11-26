using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorBurger.Elements.BurgerAdds
{
    public class ClassicBurger : IBurger
    {
        public double GetCost()
        {
            return 2.0;
        }

        public string GetDescription()
        {
            return "Basic burger";
        }
    }
}
