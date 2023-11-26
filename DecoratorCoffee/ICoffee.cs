﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCoffee
{
    public interface ICoffee
    {
        string GetDescription();
        double GetCost();
    }
}
