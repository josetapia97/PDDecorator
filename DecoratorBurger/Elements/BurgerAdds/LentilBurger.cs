using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorBurger.Elements.BurgerAdds
{
    public class LentilBurger : IBurger
    {
        public double GetCost()
        {
            return 2.5;
        }

        public string GetDescription()
        {
            return "lentil burger";
        }
    }
}
