using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    internal class ConcreteImplementation1 : IImplementation
    {
        public string OperationImplementation()
        {
            return "This is Concrete Implementation 1...";
        }
    }
}
