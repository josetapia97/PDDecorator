﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorBurger
{
    public abstract class BurgerDecorator : IBurger
    {
        protected IBurger _burger;
        public BurgerDecorator(IBurger burger)
        {
            _burger = burger;
        }
        public virtual double GetCost()
        {
            return _burger.GetCost();
        }

        public virtual string GetDescription()
        {
            return _burger.GetDescription();
        }
    }
}
