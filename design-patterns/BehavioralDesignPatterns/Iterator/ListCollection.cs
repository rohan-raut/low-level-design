using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class ListCollection : IIterableCollection
    {
        public List<int> _list;

        public ListCollection()
        {
            _list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
        }

        public IIterator CreateIterator()
        {
            return new ListIterator(_list);
        }
    }
}
