using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    // this is a concreate iterator and there could be many as such like TreeIterator, GraphIterator, LinkedListIterator etc.
    internal class ListIterator : IIterator
    {
        private List<int> _list;
        private int curr_position = 0;

        public ListIterator(List<int> list)
        {
            _list = list;
        }
        public object GetNext()
        {
            if (curr_position < _list.Count)
            {
                return _list[curr_position++];
            }

            return null;
        }

        public bool HasNext()
        {
            if (curr_position < _list.Count)
            {
                return true;
            }
            return false;
        }
    }
}
