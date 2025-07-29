using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    internal class Bus : ITransportationMode
    {
        public void GetDirection()
        {
            Console.WriteLine("Drive the Bus for 10 kms straight.");
        }

        public int GetETA()
        {
            return 5;
        }
    }
}
