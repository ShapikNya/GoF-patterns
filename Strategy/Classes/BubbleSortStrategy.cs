using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Classes
{
    public class BubbleSortStrategy : ISortStrategy
    {
        public List<int> Sort(List<int> data)
        {
            List<int> sortedData = new List<int>(data);
            for (int i = 0; i < sortedData.Count - 1; i++)
            {
                for (int j = 0; j < sortedData.Count - i - 1; j++)
                {
                    if (sortedData[j] > sortedData[j + 1])
                    {
                        int temp = sortedData[j];
                        sortedData[j] = sortedData[j + 1];
                        sortedData[j + 1] = temp;
                    }
                }
            }

            return sortedData;
        }
    }
}
