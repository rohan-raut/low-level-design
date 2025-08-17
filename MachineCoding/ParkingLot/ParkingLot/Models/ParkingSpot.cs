using ParkingLot.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    internal class ParkingSpot
    {
        private string parkingSpotId;
        private bool isOccupied = false;
        public Vehicle vehicle = null;
        public VehicleSize parkingSpotSize;

        public ParkingSpot(string parkingSpotId, VehicleSize size)
        {
            this.parkingSpotId = parkingSpotId;
            isOccupied = false;
            vehicle = null;
            parkingSpotSize = size;
        }

        public void ParkVehicle(Vehicle pVehicle)
        {
            vehicle = pVehicle;
            isOccupied = true;
        }

        public void UnParkVehicle()
        {
            vehicle = null;
            isOccupied = false;
        }

        public bool CanFit(Vehicle pVehicle)
        {
            if(parkingSpotSize == VehicleSize.LARGE)
            {
                return true;
            }
            else if(parkingSpotSize == VehicleSize.MEDIUM && (pVehicle.GetVehicleSize() == VehicleSize.MEDIUM || pVehicle.GetVehicleSize() == VehicleSize.SMALL))
            {
                return true;
            }
            else if(parkingSpotSize == VehicleSize.SMALL && pVehicle.GetVehicleSize() == VehicleSize.SMALL)
            {
                return true;
            }

            return false;
        }

        public bool IsAvailable()
        {
            return !isOccupied;
        }

        public override string ToString() 
        {
            return parkingSpotId;
        }
    }
}
