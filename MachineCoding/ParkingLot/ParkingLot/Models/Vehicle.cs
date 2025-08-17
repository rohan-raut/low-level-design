using ParkingLot.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    internal abstract class Vehicle
    {
        private VehicleSize vehicleSize;
        private string vehicleLicense;

        public Vehicle(VehicleSize vehicleSize, string vehicleLicense)
        {
            this.vehicleSize = vehicleSize;
            this.vehicleLicense = vehicleLicense;
        }

        public string GetLicense()
        {
            return vehicleLicense;
        }

        public void SetLicense(string license)
        {
            vehicleLicense = license;
        }

        public VehicleSize GetVehicleSize()
        {
            return vehicleSize;
        }
    }
}
