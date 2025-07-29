using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    internal class ClassC : ClassB
    {
        public string name;

        public ClassC(int _value, float score, string name) : base(_value, score)
        {
            this.name = name;
        }

        public override object Clone()
        {
            return new ClassC(value, score, name);
        }

        public override string ToString()
        {
            return $"name={name}; score={score}; value={value}";
        }
    }
}
