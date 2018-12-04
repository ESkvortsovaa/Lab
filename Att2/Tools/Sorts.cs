using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class Sorts
    {
        public void QuicSort(List<Measure> list) => QuickSort(list, 0, list.Count - 1);
        private void QuickSort(List<Measure> list, int left, int right)
        {
            Measure Mid = list[(left + right) / 2];
            int i = left; int j = right; do
            {
                while (list[i].CompareTo(Mid) == -1)
                    i++;
                while (list[j].CompareTo(Mid) == 1)
                    j--;
                if (i <= j)
                {
                    if (i != j)
                    {
                        Measure tmp = list[i]; list[i] = list[j]; list[j] = tmp;
                    }
                    i++; j--;
                }
            }
            while (i <= j);
            if (left < j)
                QuickSort(list, left, j);
            if (i < right)
                QuickSort(list, i, right);
        }
    }
}
