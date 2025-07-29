using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    internal class ClassA : ICloneable
    {
        public int value;

        public ClassA(int _value)
        {
            value = _value;
        }

        public virtual object Clone()
        {
            return new ClassA(value);
        }
    }
}
