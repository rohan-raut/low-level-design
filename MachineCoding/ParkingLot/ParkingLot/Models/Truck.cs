using ParkingLot.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    internal class Truck : Vehicle
    {
        public Truck(string pLicense): base(VehicleSize.LARGE, pLicense)
        {

        }
    }
}
