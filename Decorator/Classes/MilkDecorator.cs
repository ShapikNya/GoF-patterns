using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Classes
{
    public class MilkDecorator : ICoffee
    {
        private readonly ICoffee _coffee;

        public MilkDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public string GetDescription() => _coffee.GetDescription() + " + milk";
        public double GetCost() => _coffee.GetCost() + 20;

    }
}
