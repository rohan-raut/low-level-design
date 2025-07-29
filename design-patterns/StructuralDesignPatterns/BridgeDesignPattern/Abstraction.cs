using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    internal class Abstraction
    {
        private IImplementation implementation;

        public Abstraction(IImplementation implementation)
        {
            this.implementation = implementation;
        }

        public string Operation()
        {
            return implementation.OperationImplementation();
        }

        public void ChangeImplementation(IImplementation implementation)
        {
            this.implementation = implementation;
        }
    }
}
