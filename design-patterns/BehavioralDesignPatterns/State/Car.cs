using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Car : ITransportationMode
    {
        public void GetDirection()
        {
            Console.WriteLine("Drive the car for 20 kms.");
        }

        public int GetETA()
        {
            return 20;
        }
    }
}
