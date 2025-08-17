using ParkingLot.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    internal class Car : Vehicle
    {
        public Car(string pLicense) : base(VehicleSize.MEDIUM, pLicense)
        {

        }
    }
}
