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
    public class Sorter
    {
        //class variable
        private ISort sortStrategy;

        //gets and sets
        public ISort SortStrategy
        {
            get { return this.sortStrategy; }
            set { this.sortStrategy = value; }
        }

        //constructor
        //public Sorter(ISort aSortStrategy)
        //{
        //    this.sortStrategy = aSortStrategy;
        //}
        //methods
        public List<int> Sort(List<int> aList)
        {
            return this.SortStrategy.Sort(aList);
        }
    }
}
