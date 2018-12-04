using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class Sorts
    {
        //Есть некий измерительный прибор, работа которого зависит от входных параметров 
        //a и x, а результат определяется следующей формулой у = a sin(ax) cos2 (x/a). 
        //Проводится серия опытов для значений xt ,х2,... xn, a = const. Вывести результат
        //в виде таблицы, упорядоченной по убыванию значений показаний прибора, полученных 
        //в ходе опытов.
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
