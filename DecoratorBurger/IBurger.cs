using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorBurger
{
    public interface IBurger
    {
        string GetDescription();
        double GetCost();
    }
}
