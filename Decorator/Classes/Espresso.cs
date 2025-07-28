using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Classes
{
    public class Espresso : ICoffee
    {
        public string GetDescription() => "Espresso";
        public double GetCost() => 100;
    }
}
