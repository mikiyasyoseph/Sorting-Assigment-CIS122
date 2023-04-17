/*Written by
     Mikiyas Yoseph
     Niftalem Kassa
     Hermon Meteferia
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSort : ISort
    {
        //sort algorithm
        public List<int> Sort(List<int> alist)
        {
            int n = alist.Count;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (alist[j] > alist[j + 1])
                    {
                        int temp = alist[j];
                        alist[j] = alist[j + 1];
                        alist[j + 1] = temp;
                    }
                }
            }
            return alist;
        }
    }
}
