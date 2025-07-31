using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Classes
{
    public class PhoneDisplay : IObserver
    {
        private IObservable _observable;

        public PhoneDisplay(IObservable observable)
        {
            _observable = observable;
        }
        public void Update(double temperature)
        {
            Console.WriteLine($"PhoneDisplay - {temperature}");
        }
    }
}
