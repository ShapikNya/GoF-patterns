using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Classes
{
    public class LEDDisplay : IObserver
    {
        private IObservable _observable;

        public LEDDisplay(IObservable observable)
        {
            _observable = observable;
        }
        public void Update(double temperature)
        {
            Console.WriteLine($"LEDDisplay - {temperature}");
        }
    }
}
