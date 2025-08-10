using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Cycle : ITransportationMode
    {
        public void GetDirection()
        {
            Console.WriteLine("Ride the cycle for 10 kms.");
        }

        public int GetETA()
        {
            return 30;
        }
    }
}
