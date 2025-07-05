using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{

    // every concrete iterator like ListIterator, TreeIterator has to impletement this interface
    internal interface IIterator
    {
        public bool HasNext();
        public object GetNext();
    }
}
