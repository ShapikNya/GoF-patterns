using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Classes
{
    public class SugarDecorator : ICoffee
    {
        private readonly ICoffee _coffee;

        public SugarDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public string GetDescription() => _coffee.GetDescription() + " + sugar";
        public double GetCost() => _coffee.GetCost() + 5;
    }
}
