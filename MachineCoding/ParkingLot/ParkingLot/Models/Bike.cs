using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    internal class Bike : Vehicle
    {
        public Bike(string pLicense): base(Enums.VehicleSize.SMALL, pLicense)
        {

        }
    }
}
