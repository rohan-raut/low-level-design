using ParkingLot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Strategies.Parking
{
    internal class NearestFirstStrategy : IParkingStrategy
    {
        public ParkingSpot? FindAvailableSpot(List<ParkingFloor> floors, Vehicle vehicle)
        {
            foreach(ParkingFloor floor in floors)
            {
                ParkingSpot? spot = floor.FindAvailability(vehicle);
                if(spot != null)
                {
                    return spot;
                }
            }

            return null;
        }
    }
}
