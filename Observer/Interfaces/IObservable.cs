using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Interfaces
{
    public interface IObservable
    {
        public void AddObserver(IObserver observer);
        public void RemoveObservable(IObserver observer);

        public void Notify();
    }
}
