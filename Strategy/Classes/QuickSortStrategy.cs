using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Classes
{
    public class QuickSortStrategy : ISortStrategy
    {
        public List<int> Sort(List<int> data)
        {
            if (data.Count <= 1)
                return data;
            int pivotIndex = data.Count / 2;
            int pivot = data[pivotIndex];
            List<int> less = new List<int>();
            List<int> equal = new List<int>();
            List<int> greater = new List<int>();

            foreach (int num in data)
            {
                if (num < pivot)
                    less.Add(num);
                else if (num == pivot)
                    equal.Add(num);
                else
                    greater.Add(num);
            }
            return Sort(less)
                .Concat(equal)
                .Concat(Sort(greater))
                .ToList();
        }
    }
}
