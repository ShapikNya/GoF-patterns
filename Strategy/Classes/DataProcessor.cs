using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Classes
{
    public class DataProcessor
    {
        private ISortStrategy _strategy;

        public List<int> Process(List<int> data)
        {
            if (_strategy is null) throw new Exception("Стратегия не выбрана!");
            return _strategy.Sort(data);
        }

        public void SetSortStrategy(ISortStrategy strategy)
        {
            if (strategy is null) throw new ArgumentNullException();
            _strategy = strategy;
        }


    }
}
