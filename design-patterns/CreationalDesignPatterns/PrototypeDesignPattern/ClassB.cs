using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    internal class ClassB : ClassA
    {
        public float score;

        public ClassB(int _value, float score) : base(_value)
        {
            this.score = score;
        }

        public override object Clone()
        {
            return new ClassB(value, score);
        }
    }
}
