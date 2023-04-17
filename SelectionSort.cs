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
    public class SelectionSort : ISort
    {
        //sort alghorithm
        public List<int> Sort(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                var key = list[i];
                var flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (key < list[j])
                    {
                        list[j + 1] = list[j];
                        j--;
                        list[j + 1] = key;
                    }
                    else flag = 1;
                }
            }
            return list;
        }
    }
}
