using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    internal interface IterableCollection
    {
        public IIterator CreateIterator();
    }
}
