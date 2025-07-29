using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class Truck : IVehicle
    {
        public void Deliver()
        {
            Console.WriteLine("Delivering by Truck");
        }
    }
}
