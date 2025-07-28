using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Classes
{
    public class SoundSystem
    {
        public void TurnOn() => Console.WriteLine("Sound system is ON");
        public void TurnOff() => Console.WriteLine("Sound system is OFF");
    }
}
