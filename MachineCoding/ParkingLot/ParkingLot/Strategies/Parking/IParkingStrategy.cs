using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingLot.Models;

namespace ParkingLot.Strategies.Parking
{
    internal interface IParkingStrategy
    {
        ParkingSpot? FindAvailableSpot(List<ParkingFloor> floors, Vehicle vehicle);
    }
}
