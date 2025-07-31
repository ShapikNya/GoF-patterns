using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Classes
{
    public class WeatherStation : IObservable
    {
        private List<IObserver> _observers = new List<IObserver>();

        private double _temperature;

        public void SetTemperature(double temperature)
        {
            _temperature = temperature; Notify();
        }
            
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObservable(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers) {observer.Update(_temperature); }
        }


    }
}
