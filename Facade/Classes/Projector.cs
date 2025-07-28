using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Classes
{
    public class Projector
    {
        public void On() => Console.WriteLine("Projector is ON");
        public void Off() => Console.WriteLine("Projector is OFF");
    }
}
